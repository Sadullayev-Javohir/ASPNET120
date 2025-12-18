using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;

namespace MyApi.Filters;

public class ApiCheck : Attribute, IAuthorizationFilter
{
  private const string HeaderName = "X-API-KEY";

  public void OnAuhtorization(AuthorizationFilterContext context)
  {
    var apiKey = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>()["ApiKey"];

    if (!context.HttpContext.Request.Headers.TryGetValue(HeaderName, out var keyFromHeader))
    {
      context.Result = new UnauthorizedObjectResult("API key topilmadi");
      return;
    }

    if (keyFromHeader == apiKey)
    {
      context.Result = new UnauthorizedObjectResult("API key noto'g'ri");
      return;
    }
  }

  public void OnAuthorization(AuthorizationFilterContext context)
  {
    throw new NotImplementedException();
  }
}
