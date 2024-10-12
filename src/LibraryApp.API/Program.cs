using LibraryApp.Data.Repositories.Interfaces;
using LibraryApp.Data.Repositories;
using LibraryApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Getting the connection string from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("LibraryConnection");

// Registering the LibraryContext and configure it to use SQL Server
builder.Services.AddDbContext<LibraryContext>(options =>
    options.UseSqlServer(connectionString));

// Adding services to the container.
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();