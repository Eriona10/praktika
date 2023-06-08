using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Ocelot.Values;
using Pet.Microservice.Data;
using Pet.Microservice.Data.Entieties;
using Pet.Microservice.Interfaces;
/*using Pet.Microservice.Services;*/

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PetDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDbContext<PetTrackerContext>(options =>
   options.UseSqlServer(connectionString));


builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add your pet service and repository to the container
/*builder.Services.AddScoped<IPetService, PetService>();*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Map the pet route
app.MapControllers();

app.Run();






