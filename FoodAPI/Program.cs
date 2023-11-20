using FoodAPI.Data;
using FoodAPI.Services;
using Microsoft.EntityFrameworkCore;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("localhost");

builder.Services.AddDbContext<AppDbContext>(o
    => o.UseSqlServer(connectionString));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/dev", () => "Hello developer!");

app.Run();
