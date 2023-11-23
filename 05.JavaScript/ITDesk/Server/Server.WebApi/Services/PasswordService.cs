using System.Text;

namespace Server.WebApi.Services;

public static class PasswordService
{
    public static void CreatePassword(string password, out byte[] passwordSalt, out byte[] passwordHash)
    {
        using(var hmac = new System.Security.Cryptography.HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
    }
}