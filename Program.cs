using Infra.Context;
using Infra.Repositories;
using Infra.Repositories.Interfaces;

using Service.Services;
using Service.Interfaces;
using Service.Validations;
using Service.Providers;

using API.Errors;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
builder.Services.AddScoped(typeof(IHashProvider), typeof(HashProvider));

builder.Services.AddTransient<IUserServiceCollection, UserServiceCollection>();

var app = builder.Build();

app.MapPost("/user", (IUserServiceCollection userService, ValidateUserProps userProps) =>
{
    try
    {
        var user = userService.SignUp(userProps);
        return Results.Ok(user);
    }
    catch (AppError ex)
    {
        return Results.Problem(statusCode: ex.statusCode, detail: ex.message);
    }
    catch
    {
        return Results.Problem(statusCode: 500, detail: "Internal Server Error");
    }
});

app.Run("http://localhost:3001");


