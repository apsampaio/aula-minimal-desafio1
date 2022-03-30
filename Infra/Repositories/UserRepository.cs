using Infra.Repositories.Interfaces;
using Infra.Context;
using Model;

using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories;

public class UserRepository : IUserRepository
{

    private readonly DatabaseContext _databaseContext;
    private DbSet<User> entity;

    public UserRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
        entity = _databaseContext.Set<User>();
    }

    // Sempre que o metodo Create for Invocado
    // Ele CRIA e SALVA um usuario no Banco de Dados
    public void Create(User user)
    {
        entity.Add(user);
        _databaseContext.SaveChanges();
    }

    public void SaveChanges()
    {
        _databaseContext.SaveChanges();
    }

}