using Model;
using Infra.Context;
using Infra.Repositories;
using Infra.Repositories.Interfaces;
using Service.Services;
using Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddScoped(typeof(IUserRepository), typeof(UserRepository));

builder.Services.AddTransient<IUserServiceCollection, UserServiceCollection>();

var app = builder.Build();

app.MapPost("/user", (CreateUser userProps, IUserServiceCollection userService) =>
{
    var user = userService.SignUp(userProps);
    return Results.Ok(user);
});

app.Run("http://localhost:3001");


