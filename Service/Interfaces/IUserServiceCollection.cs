using Model;

namespace Service.Interfaces;

public interface IUserServiceCollection
{
    // Registro do Usuario
    User SignUp(CreateUser props);

    // Login do Usuario
    string SignIn();
}