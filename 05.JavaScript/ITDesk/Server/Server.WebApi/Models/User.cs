namespace Server.WebApi.Models;

public sealed class User
{
    public User()
    {
        Id = Guid.NewGuid();
        IsAdmin = false;
    }
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public byte[] PasswordSalt { get; set; } = new byte[128];
    public byte[] PasswordHash { get; set; } = new byte[64];
    public bool IsAdmin { get; set; }
}
