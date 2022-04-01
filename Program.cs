using API;
using API.Routes;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterDatabase();
builder.Services.DependencyInjection();
builder.Services.ConfigureCORS();

var app = builder.Build();

app.UseCors("CORS");
app.ConfigureRoutes();

app.Run("http://localhost:3001");


