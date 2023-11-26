namespace Server.WebApi.Options;

public sealed class Jwt
{
    public string Issuer { get; set; } = String.Empty;
    public string Audience { get; set; } = String.Empty;
    public string SecretKey { get; set;} = String.Empty;
}
