using BreweryManagementSystem.DataContext;
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

/*
DataContext f = new DataContext();
var l = f.Brewery.Include(p => p.Beers).ToList();
var t = f.Beer.Include(p => p.Brewery).ToList(); 
var y = f.Beer.ToList();
var z = f.BreweryBeer.ToList(); 
*/

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
