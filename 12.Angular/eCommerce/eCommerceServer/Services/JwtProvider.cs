using eCommerceServer.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace eCommerceServer.Services;

public sealed class JwtProvider
{
    public string CreateToken(AppUser user)
    {
        IEnumerable<Claim> claims = new List<Claim>()
        {
            new Claim("Email",user.Email),
            new Claim(ClaimTypes.Name, string.Join(" ",user.FirstName,user.LastName)),
        };

        DateTime expires = DateTime.Now.AddMinutes(20);

        JwtSecurityToken jwtSecurityToken = new(
            issuer: "Taner Saydam",
            audience: "localhost:4200",
            claims: claims,
            notBefore: DateTime.Now,
            expires: expires,
            signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("my secret key my secret key my secret key my secret key my secret key my secret key 23123123.sadasdasd")),SecurityAlgorithms.HmacSha512));

        JwtSecurityTokenHandler handler = new();
        string token = handler.WriteToken(jwtSecurityToken);

        return token;
    }
}
