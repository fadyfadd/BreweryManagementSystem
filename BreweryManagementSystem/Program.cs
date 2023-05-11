using BreweryManagementSystem.Infrastructure;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BreweryManagementSystem;
using BreweryManagementSystem.Models;

var builder = WebApplication.CreateBuilder(args);

 
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<IDataAccessLayer, DataAccessLayer>();
builder.Services.AddScoped<IBusinessLogic,BusinessLogic>();
builder.Services.AddScoped<BreweryManagementSystemContext>(); 
builder.Services.AddOptions();
var app = builder.Build(); 
 

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
