using LibraryApp.API.Services;
using LibraryApp.Data;
using LibraryApp.Data.Repositories.Interfaces;
using LibraryApp.Data.Repositories;
using LibraryApp.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using LibraryApp.API.Interfaces;
using LibraryApp.API.Profiles;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Connection string of Database from Config files
var connectionString = builder.Configuration.GetConnectionString("LibraryConnection");

// Adding services to the container
builder.Services.AddDbContext<LibraryContext>(options =>
    options.UseSqlServer(connectionString));

// Configuring Identity
builder.Services.AddIdentityCore<AppUser>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.User.RequireUniqueEmail = true;
})
.AddEntityFrameworkStores<LibraryContext>()
.AddSignInManager<SignInManager<AppUser>>();

// Adding JWT authentication
var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["TokenKey"]));
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opt =>
    {
        opt.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = key,
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

// Authorization policies
builder.Services.AddAuthorization(opt =>
{
    opt.AddPolicy("LibrarianOnly", policy =>
    {
        policy.RequireClaim("IsLibrarian", "True");
    });
});

// Register AutoMapper with the MappingProfile
builder.Services.AddAutoMapper(typeof(MappingProfile));


// Adding services to the container.
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ITokenService, TokenService>();

builder.Services.AddControllers();

// Adding Swagger for API documentation
builder.Services.AddEndpointsApiExplorer();

// Configuring Swagger to support JWT authentication
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "LibraryApp API", Version = "v1" });

    // Add JWT authentication to Swagger
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: 'Bearer {token}'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LibraryApp API v1"));
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
