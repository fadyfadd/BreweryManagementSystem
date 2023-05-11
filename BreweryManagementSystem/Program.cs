using BreweryManagementSystem.Infrastructure;
using System.Linq;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

 
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


BreweryManagementSystem.Models.BreweryManagementSystemContext f = new BreweryManagementSystem.Models.BreweryManagementSystemContext();
var x = f.Beers.ToList();


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
