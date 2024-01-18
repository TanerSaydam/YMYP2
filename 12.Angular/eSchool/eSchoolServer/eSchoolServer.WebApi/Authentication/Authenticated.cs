using eSchoolServer.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace eSchoolServer.WebApi.Authentication;

public class Authenticated : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        string? secretKey = context.HttpContext.Request.Headers.Where(p => p.Key == "secretkey").FirstOrDefault().Value;

        if (secretKey != AuthController.SecretKey)
        {
            throw new ArgumentException("You are not authenticated!");
        }
    }
}


