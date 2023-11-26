using Server.WebApi.Models;
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

    public static bool CheckPassword(User user,string password)
    {
        using (var hmac = new System.Security.Cryptography.HMACSHA512(user.PasswordSalt))
        {
            var newPassword = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            for (int i = 0; i < user.PasswordHash.Length; i++)
            {
                if (newPassword[i] != user.PasswordHash[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}