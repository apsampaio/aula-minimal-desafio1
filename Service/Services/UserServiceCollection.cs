using Service.Interfaces;
using Infra.Repositories.Interfaces;
using Model;
using Service.Validations;
using API.Errors;

namespace Service.Services;

public class UserServiceCollection : IUserServiceCollection
{
    private readonly IUserRepository _userRepository;
    private readonly IHashProvider _hashProvider;

    public UserServiceCollection(IUserRepository userRepository, IHashProvider hashProvider)
    {
        _userRepository = userRepository;
        _hashProvider = hashProvider;
    }

    public User SignUp(ValidateUserProps userProps)
    {
        userProps.Validate();

        // Verificar se username nao este sendo utilizado

        var userExists = _userRepository.FindByUsername(userProps.username);


        if (userExists != null)
        {
            throw new AppError("Username já utilizado", 400);
        }

        // Realizar o Hash do nosso Password

        var hashedPassword = _hashProvider.HashPassword(userProps.password);

        // Cria o usuario no Banco de Dados

        var user = new User
        {
            id = Guid.NewGuid(),
            username = userProps.username,
            password = hashedPassword,
            name = userProps.name,
        };

        _userRepository.Create(user);

        return user;
    }

    public string SignIn()
    {
        return "Hello World!";
    }
}