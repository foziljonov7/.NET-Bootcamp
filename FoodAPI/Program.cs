using System.Net;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/dev", () => "Hello developer!");

app.Run();
