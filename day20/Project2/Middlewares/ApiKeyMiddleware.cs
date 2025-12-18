using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Project2.Middlewares;

public class ApiKeyMiddleware
{
  private readonly RequestDelegate _next;

  private const string APIKEYNAME = "X-API-KEY";

  private const string APIKEY = "Secret123";

  public ApiKeyMiddleware(RequestDelegate next) => _next = next;

  public async Task InvokeAsync(HttpContent context)
  {
    if (!context.Request.Headers.TryGetValue(APIKEYNAME, out var extractedApiKey))
    {
      context.Response.StatusCode = StatusCodes.Status401Unauhtorized;
      await context.Response.WriteAsync("Api key topilmadi");
      return;
    }

    if (!APIKEY.Equals(extractedApiKey))
    {
      context.Response.StatusCode = StatusCodes.Status401Unauhtorized;
      await context.Response.WriteAsync("Api key noto'g'ri");
      return;
    }
    await _next(context);
  }
}
