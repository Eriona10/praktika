
 //using Location.Microservice.Data;
 using Microsoft.EntityFrameworkCore;

//using Location.Microservice.Data.Entieties;
//using Location.Microservice.Repository.User;
using Microsoft.AspNetCore.Identity;
using Location.Microservice;
//using Location.Microservice.Data;
using Location.Microservice.Models;
using Location.Microservice.Interfaces;
using Location.Microservice.Services;
using Location.Microservice.Data.Entieties;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<ILocationServices, LocationService>();
//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<PetTrackerContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<ILocationServices, LocationService>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();