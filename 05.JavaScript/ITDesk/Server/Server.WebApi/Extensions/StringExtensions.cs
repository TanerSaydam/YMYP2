namespace Server.WebApi.Extensions;

public static class StringExtensions
{
    public static bool IsNullEmptyOrWhiteSpace(
        this string str)
    {
        return str == null || string.IsNullOrWhiteSpace(str);
    }
}
