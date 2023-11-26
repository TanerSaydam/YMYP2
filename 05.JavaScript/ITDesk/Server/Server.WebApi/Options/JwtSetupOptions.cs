using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Server.WebApi.Options;

public sealed class JwtSetupOptions : IPostConfigureOptions<JwtBearerOptions>
{
    private readonly Jwt _jwt;

    public JwtSetupOptions(IOptions<Jwt> jwt)
    {
        _jwt = jwt.Value;
    }

    public void PostConfigure(string? name, JwtBearerOptions options)
    {
        options.TokenValidationParameters.ValidateIssuer = true;
        options.TokenValidationParameters.ValidateAudience = true;
        options.TokenValidationParameters.ValidateIssuerSigningKey = true;
        options.TokenValidationParameters.ValidateLifetime = true;        
        options.TokenValidationParameters.ValidIssuer = _jwt.Issuer;
        options.TokenValidationParameters.ValidAudience = _jwt.Audience;
        options.TokenValidationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.SecretKey));
    }
}
