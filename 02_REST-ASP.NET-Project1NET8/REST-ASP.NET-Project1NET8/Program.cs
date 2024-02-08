using Microsoft.EntityFrameworkCore;
using REST_ASP.NET_Project1NET8.Business;
using REST_ASP.NET_Project1NET8.Business.Implementations;
using REST_ASP.NET_Project1NET8.Model.Context;
using REST_ASP.NET_Project1NET8.Repository;
using REST_ASP.NET_Project1NET8.Repository.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connection = builder.Configuration["MySqlConnection:MySqlConnectionString"];
builder.Services.AddDbContext<MySqlContext>(options => options.UseMySql(
    connection, new MySqlServerVersion(new Version(8,0,35))));

// API Versioning
builder.Services.AddApiVersioning();

// Dependency Injection
builder.Services.AddScoped<IPersonBusiness, PersonBusinessImplementation>();
builder.Services.AddScoped<IPersonRepository, PersonRepositoryImplementation>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
