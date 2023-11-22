using FoodAPI.Data;
using FoodAPI.Services;
using Microsoft.EntityFrameworkCore;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("localhost");

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(o
    => o.UseSqlServer(connectionString));

builder.Services.AddScoped<IFoodService, FoodService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
