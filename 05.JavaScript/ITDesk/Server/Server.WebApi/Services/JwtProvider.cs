using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Server.WebApi.DTOs;
using Server.WebApi.Models;
using Server.WebApi.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Server.WebApi.Services;

public sealed class JwtProvider
{
    private readonly Jwt _jwt;

    public JwtProvider(IOptions<Jwt> jwt)
    {
        _jwt = jwt.Value;
    }

    public LoginResponseDto CreateToken(User user, bool rememberMe)
    {
        List<Claim> claims = new()
        {
            new Claim("UserId", user.Id.ToString()),
            new Claim("Username", user.UserName),
            new Claim(ClaimTypes.Email, user.Email)
        }; //key ve value 

        DateTime expires = rememberMe ? DateTime.Now.AddMonths(1) : DateTime.Now.AddDays(1);

        string secretKey = _jwt.SecretKey;

        var symmetricSecurityKey = new SymmetricSecurityKey(
                                    Encoding.UTF8.GetBytes(secretKey));
        var credentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha512);

        JwtSecurityToken securityToken = new(
            issuer: _jwt.Issuer, //uygulanın kime ait olduğu
            audience: _jwt.Audience, //uygulamayı kimin kullanacağı
            claims: claims, //body alanımız
            notBefore: DateTime.Now, //tokenın ne zaman başlayacağı
            expires: expires, //token ne zaman biteceği
            signingCredentials: credentials); //şifreleme anahtarımız

        JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
        string token = handler.WriteToken(securityToken);


        return new(token, user.Id);
    }
}
