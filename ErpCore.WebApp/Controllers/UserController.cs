using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories;
using ErpCore.WebApp.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace ErpCore.WebApp.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserApiClient _userApiClient;
        public UserController(IUserApiClient userApiClient, ILogger<UserController> logger) 
        { 
            _userApiClient = userApiClient; 
        }
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model) 
        {

            if (!ModelState.IsValid)
               return View(ModelState);

            var tokenModel = await _userApiClient.Authenticate(model);
            if (tokenModel != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, model.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, tokenModel.accessToken!),
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var authProperties = new AuthenticationProperties
                {
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(60),
                    IsPersistent = true,
                    
                };

                var cookieOptions = new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddMinutes(30),
                    IsEssential = true, // đảm bảo rằng cookie sẽ được gửi đi ngay cả khi người dùng không xác thực
                    HttpOnly = true, // chỉ cho phép truy cập qua HTTP, không cho phép JavaScript truy cập cookie này
                    SameSite = SameSiteMode.Strict // chỉ cho phép gửi cookie khi đang ở cùng một trang web (same-site)
                };

                Response.Cookies.Append("access_token", tokenModel.accessToken!, cookieOptions);
                Response.Cookies.Append("refresh_token", tokenModel.refreshToken!, cookieOptions);
                /* HttpContext.Session.SetString("access_tonken", tokenModel.accessToken!);
                HttpContext.Session.SetString("refresh_token", tokenModel.refreshToken!);*/

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authProperties);
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
                return View(ModelState);
            var result = await _userApiClient.RegisterUser(model);
            if (result != false)
            {
                return RedirectToAction("Login", "User");
            }

            ModelState.AddModelError(string.Empty, "Fail Register");
            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login","User");
        }
    }
}
