using Service.Interfaces;
using Infra.Repositories.Interfaces;
using Model;
using Service.Validations;
using API.Errors;

namespace Service.Services;

public class UserServiceCollection : IUserServiceCollection
{
    private readonly IUserRepository _userRepository;

    public UserServiceCollection(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public User SignUp(ValidateUserProps userProps)
    {
        userProps.Validate();

        var user = new User
        {
            id = Guid.NewGuid(),
            username = userProps.username,
            password = userProps.password,
            name = userProps.name,
            isAdmin = false
        };

        _userRepository.Create(user);

        return user;
    }

    public string SignIn()
    {
        return "Hello World!";
    }
}