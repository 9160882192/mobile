using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Welcome to the ASP.NET Core Web API!");
app.MapGet("/hello", (string name) => $"Hello, {name}!");

app.Run();
