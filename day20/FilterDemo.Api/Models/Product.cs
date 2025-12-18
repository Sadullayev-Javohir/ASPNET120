using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class AdminOnlyAttribute : Attribute, IAuthorizationFilter
{
  public void OnAuhtorization(AuthorizationFilterContext context)
  {
    var role = context.HttpContext.Request.Headers["Role"].ToString();

    if (role != "Admin")
    {
      context.Result = new ContentResult()
      {
        StatusCode = 403,
        Content = "Siz Admin emassiz, bu yerga kirish mumkin emas."
      };
    }
  }
}
