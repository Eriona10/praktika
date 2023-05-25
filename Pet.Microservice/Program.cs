using Fluent.Infrastructure.FluentModel;
using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using Pet.Microservice;
using Pet.Microservice.Interfaces;
using Pet.Microservice.Services;
using User.Microservice.Data.Entieties;
using User.Microservice.Repository.General;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PetDbContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddControllers();
var app = builder.Build();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



// lidhja e interfaces me services
//builder.Services.AddScoped<IPetService, PetService>();
//var app = builder.Build();

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






