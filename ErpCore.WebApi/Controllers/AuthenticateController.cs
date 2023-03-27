using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories;
using ErpCore.Common.Shared.Model;
using ErpCore.Database.EF;
using ErpCore.Database.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;

namespace ErpCore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IJWTManagerRepository _jWTManager;
        private readonly ErpDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AuthenticateController(UserManager<User> userManager, SignInManager<User> signInManager
            , IJWTManagerRepository jWTManager, ErpDbContext repo, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _jWTManager = jWTManager;
            _context = repo;
            _signInManager = signInManager;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

            if (result.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                var roles = await _userManager.GetRolesAsync(user);
                var idUser = await _userManager.GetUserIdAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim("Id",idUser),
                    new Claim(ClaimTypes.Email,model.Email),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
                };

                foreach (var claim in roles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, claim));
                }

                var accessToken = _jWTManager.CreateToken(authClaims);
                var refreshToken = _jWTManager.GenerateRefreshToken();

                /*await _userManager.SetAuthenticationTokenAsync(user, "ERP", "refresh_token", refreshToken);*/
                //Access vào Database 
                var refreshTokenEntity = new UserRefreshToken
                {
                    CreatedAt = DateTime.UtcNow,
                    ExpiresAt = DateTime.UtcNow.AddHours(1),
                    JwtId = accessToken.Id,
                    Token = refreshToken,
                    IsRevoked = false,
                    IsUserd = false,
                    UserId = user.Id,
                };

                await _context.AddAsync(refreshTokenEntity);
                await _context.SaveChangesAsync();

                return Ok(new TokenModel 
                {
                    accessToken = new JwtSecurityTokenHandler().WriteToken(accessToken),
                    refreshToken = refreshToken,
                });
            }
            return Unauthorized();
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var userExists = await _userManager.FindByNameAsync(model.Email);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

            var user = new User
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });
              
            }

            /*var customer = new Customer()
            {
                Email = model.Email
            };

            user.Customer = customer;
            await _context.Customers.AddAsync(customer
            await _context.SaveChangesAsync(););
            await _userManager.AddToRoleAsync(user, "Customer");*/

            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }

        [HttpPost]
        [Route("register-admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel model)
        {
            var userExists = await _userManager.FindByNameAsync(model.Email);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new { Status = "Error", Message = "User already exists!" });

            var user = new User
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Email
            }; 

            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            if (!await _roleManager.RoleExistsAsync("Admin"))
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
            if (!await _roleManager.RoleExistsAsync("User"))
                await _roleManager.CreateAsync(new IdentityRole("User"));

            if (await _roleManager.RoleExistsAsync("Admin"))
            {
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            if (await _roleManager.RoleExistsAsync("User"))
            {
                await _userManager.AddToRoleAsync(user, "User");
            }
            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }

        [HttpPost]
        [Route("refresh-token")]
        public async Task<IActionResult> RefreshToken(TokenModel tokenModel)
        {
            if (tokenModel is null)
            {
                return BadRequest("Invalid client request");
            }

            try
            {
                //check 1: AccessToken valid format
                var tokenInVerification = _jWTManager.GetPrincipalFromExpiredToken(tokenModel.accessToken!);
                if (tokenInVerification == null)
                {
                    return BadRequest("Invalid access token or refresh token");
                }

                //check 2: Check accessToken expire?
                var utcExpireDate = long.Parse(tokenInVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Exp)!.Value);

                var expireDate = ConvertUnixTimeToDateTime(utcExpireDate);
                if (expireDate > DateTime.UtcNow)
                {
                    return Ok(new Response
                    {
                        Status = "Error",
                        Message = "Access token has not yet expired"
                    });
                }

                //check 3: Check refreshtoken exist in DB
                var storedToken = _context.UserRefreshTokens.FirstOrDefault(x => x.Token == tokenModel.refreshToken);
                if (storedToken == null)
                {
                    return Ok(new Response
                    {
                        Status = "Error",
                        Message = "Refresh token does not exist"
                    });
                }

                //check 4: check refreshToken is used/revoked?
                if (storedToken.IsUserd)
                {
                    return Ok(new Response
                    {
                        Status = "Error",
                        Message = "Refresh token has been used"
                    });
                }
                if (storedToken.IsRevoked)
                {
                    return Ok(new Response
                    {
                        Status = "Error",
                        Message = "Refresh token has been revoked"
                    });
                }

                //check 5: AccessToken id == JwtId in RefreshToken
                var jti = tokenInVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti)!.Value;
                if (storedToken.JwtId != jti)
                {
                    return Ok(new Response
                    {
                        Status = "Error",
                        Message = "Token doesn't match"
                    });
                }

                //Update token is used
                storedToken.IsRevoked = true;
                storedToken.IsUserd = true;
                _context.Update(storedToken);
                await _context.SaveChangesAsync();

                //create new token
                var newAccessToken = _jWTManager.CreateToken(tokenInVerification.Claims.ToList());
                var newRefreshToken = _jWTManager.GenerateRefreshToken();

                var refreshTokenEntity = new UserRefreshToken
                {
                    CreatedAt = DateTime.UtcNow,
                    ExpiresAt = DateTime.UtcNow.AddHours(1),
                    JwtId = newAccessToken.Id,
                    Token = newRefreshToken,
                    IsRevoked = false,
                    IsUserd = false,
                    UserId = storedToken.UserId,
                };

                await _context.AddAsync(refreshTokenEntity);
                await _context.SaveChangesAsync();

                return Ok(new TokenModel
                {
                    accessToken = new JwtSecurityTokenHandler().WriteToken(newAccessToken),
                    refreshToken = newRefreshToken,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new Response 
                {
                    Status = "Error",
                    Message = "Something went wrong"
                });
            }
        }

        private DateTime ConvertUnixTimeToDateTime(long utcExpireDate)
        {
            var dateTimeInterval = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTimeInterval = dateTimeInterval.AddSeconds(utcExpireDate).ToUniversalTime();
            TimeSpan span = TimeSpan.FromSeconds(1);
            return dateTimeInterval;
        }


        [Authorize]
        [HttpPost]
        [Route("revoke/{username}")]
        public async Task<IActionResult> Revoke(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user == null) return BadRequest("Invalid user name");

            var storedToken = _context.UserRefreshTokens.FirstOrDefault(x => x.UserId == user.Id);
            storedToken!.IsRevoked = true;
            _context.Update(storedToken);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [Authorize]
        [HttpPost]
        [Route("revoke-all")]
        public async Task<IActionResult> RevokeAll()
        {
            var users = _userManager.Users.ToList();
            foreach (var user in users)
            {
                var storedToken = _context.UserRefreshTokens.FirstOrDefault(x => x.UserId == user.Id);
                storedToken!.IsRevoked = true;
                _context.Update(storedToken);
                await _context.SaveChangesAsync();
            }

            return NoContent();
        }
    }
}
