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
using Microsoft.AspNetCore.Authorization;
using LibraryApp.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Connection string of Database from Config files
var connectionString = builder.Configuration.GetConnectionString("LibraryConnection");

// Adding services to the container
builder.Services.AddDbContext<LibraryContext>(options =>
    options.UseSqlServer(connectionString));

// Configuring Identity with roles
builder.Services.AddIdentity<AppUser, IdentityRole>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.User.RequireUniqueEmail = true;
})
.AddEntityFrameworkStores<LibraryContext>()
.AddSignInManager<SignInManager<AppUser>>()
.AddDefaultTokenProviders();


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
builder.Services.AddAuthorization(options =>
{
    // Policy for librarians only
    options.AddPolicy("LibrarianOnly", policy =>
    {
        policy.RequireRole("Librarian");
    });

    // Policy for students only
    options.AddPolicy("StudentOnly", policy =>
    {
        policy.RequireRole("Student");
    });

    // Fallback policy for authenticated users
    options.FallbackPolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
});

// Register AutoMapper with the MappingProfile
builder.Services.AddAutoMapper(typeof(MappingProfile));

var AllowSpecificOrigins = "_allowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:3000", "https://localhost:5108")
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials();
        });
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.LogoutPath = "/Account/Logout";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.Events.OnRedirectToLogin = context =>
    {
        context.Response.Redirect("/Account/Login");
        return Task.CompletedTask;
    };
});



// Adding services to the container.
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ITokenService, TokenService>();

//Email Handler Service registration
var smtpSettings = builder.Configuration.GetSection("SmtpSettings");
builder.Services.AddTransient<IEmailSenderService>(provider =>
    new EmailSenderService(
        smtpSettings["Server"],
        int.Parse(smtpSettings["Port"]),
        smtpSettings["FromEmail"],
        smtpSettings["Password"]
    )
);

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
app.UseCors(AllowSpecificOrigins);

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

// Seed the roles during application startup
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        await services.SeedRoles();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while seeding roles.");
    }
}

app.Run();

