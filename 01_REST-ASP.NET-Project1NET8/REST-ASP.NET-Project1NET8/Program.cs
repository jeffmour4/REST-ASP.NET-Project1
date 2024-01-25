using Microsoft.EntityFrameworkCore;
using REST_ASP.NET_Project1NET8.Model.Context;
using REST_ASP.NET_Project1NET8.Services;
using REST_ASP.NET_Project1NET8.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connection = builder.Configuration["MySqlConnection:MySqlConnectionString"];
builder.Services.AddDbContext<MySqlContext>(options => options.UseMySql(
    connection, new MySqlServerVersion(new Version(8,0,35))));

// Dependency Injection
builder.Services.AddScoped<IPersonService, PersonServiceImplementation>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
