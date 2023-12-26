using eCommerceServer.Context;
using eCommerceServer.Models;

namespace eCommerceServer.Repositories;

public class AppUserRepository
{
    private readonly ApplicationDbContext context;
    public AppUserRepository()
    {
        context = new();
    }
    public void Add(AppUser user)
    {        
        context.Users.Add(user);
        context.SaveChanges();
    }

    public bool IsEmailExists(string email)
    {
        return context.Users.Any(p => p.Email == email);
    }

    public AppUser? Login(string email, string password)
    {
        return context.Users.FirstOrDefault(p=> p.Email == email && p.Password == password);
    }
}
