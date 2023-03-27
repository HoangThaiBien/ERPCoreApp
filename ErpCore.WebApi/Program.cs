using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Helpers;
using ErpCore.Business.Logic.Repositories.Implement;
using ErpCore.Business.Logic.Repositories.Interface;
using ErpCore.Business.Logic.Repositories;
using ErpCore.Business.Logic.Services;
using ErpCore.Database.EF;
using ErpCore.Database.Entities;
using ErpCore.Database.Seeders;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("ErpCoreDb");
builder.Services.AddDbContext<ErpDbContext>(options => options.UseSqlServer(connectionString));

//DI 
/*builder.Services.AddScoped<IAccountRepository,AccountRepository>();
builder.Services.AddScoped<ITagRepository, TagRepository>();*/
builder.Services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
builder.Services.AddScoped<IRepository<Tag, TagModel>, Repository<Tag, TagModel>>();
builder.Services.AddScoped<IJWTManagerRepository, JWTManagerRepository>();
builder.Services.AddScoped<IUserService, UserService>();
//Auto Map
builder.Services.AddAutoMapper(typeof(ProductModel).Assembly);

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//CORS
builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

//Identity User
builder.Services.AddIdentity<User, IdentityRole>().
    AddEntityFrameworkStores<ErpDbContext>().
    AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireDigit = true;

    /*options.Lockout.AllowedForNewUsers = true;*/
    options.Lockout.MaxFailedAccessAttempts = 2; // Số lần đăng nhập sai tối đa trước khi khóa tài khoản
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(2); // Thời gian khóa tài khoản mặc định (5 phút)
    /*options.SignIn.RequireConfirmedAccount = true;*/
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;
});

//add poclicy
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOrManager", policy =>
        policy.RequireRole("Admin","Manager"));
});


//add JWt
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
        //Tu cap token
        ValidateIssuer = true,
        ValidateAudience = true,
        //life time token
        ValidateLifetime = true,
        //ky vao token
        ValidateIssuerSigningKey = true,
        ClockSkew = TimeSpan.Zero
    };
});

//Jwt in SwaggerGen implement authorization
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition(name: "Bearer", securityScheme: new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Enter the Bearer Authorization string as following: `Bearer Generated-JWT-Token`",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Name = "Bearer",
                    In = ParameterLocation.Header,
                    Reference = new OpenApiReference
                    {
                        Id = "Bearer",
                        Type = ReferenceType.SecurityScheme
                    }
                },
                new List<string>()
            }
        });
});

var app = builder.Build();
// Configure the HTTP request pipeline.
using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var database = scope.ServiceProvider.GetRequiredService<ErpDbContext>();
    await database.Database.MigrateAsync();
    await ErpSeeder.InitializeAsync(database, userManager, roleManager);
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(/*c => c.SwaggerEndpoint("/swagger/v1/swagger.jon", "dotnetClaimAuthorization v1")*/);
}

app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();