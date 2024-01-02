using eCommerceServer.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace eCommerceServer.Services;

public sealed class JwtProvider
{
    IConfiguration _configuration;
    public JwtProvider(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public string CreateToken(AppUser user)
    {
        IEnumerable<Claim> claims = new List<Claim>()
        {
            new Claim("UserId",user.Id.ToString()),
            new Claim("Email",user.Email),
            new Claim("Name", string.Join(" ",user.FirstName,user.LastName)),
        };

        DateTime expires = DateTime.Now.AddMonths(1);
        JwtSecurityToken jwtSecurityToken = new(
            issuer: _configuration.GetSection("Jwt:Issuer").Value,
            audience: _configuration.GetSection("Jwt:Audience").Value,
            claims: claims,
            notBefore: DateTime.Now,
            expires: expires,
            signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("Jwt:SecretKey").Value ?? "")),SecurityAlgorithms.HmacSha512));

        JwtSecurityTokenHandler handler = new();
        string token = handler.WriteToken(jwtSecurityToken);

        return token;
    }
}
