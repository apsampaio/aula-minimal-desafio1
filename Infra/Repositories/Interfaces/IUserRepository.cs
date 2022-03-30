using Model;

namespace Infra.Repositories.Interfaces;

public interface IUserRepository
{
    void Create(User user);
    void SaveChanges();
}