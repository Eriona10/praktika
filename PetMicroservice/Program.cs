using Microsoft.EntityFrameworkCore;
using PetMicroservice.Data.Entieties;
using PetMicroservice.Interfaces;
using PetMicroservice.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PetTrackerContext>(options =>
   options.UseSqlServer(connectionString));

builder.Services.AddScoped<IPetService, PetService>();

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
