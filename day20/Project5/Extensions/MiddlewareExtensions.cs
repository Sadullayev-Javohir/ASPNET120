using Microsoft.AspNetCore.Builder;
using Project5.Middlewares;

namespace Project5.Extensions;

public static class MiddlewareExtensions
{
  public static IApplicationBuilder UseMeningSoqchim(this IApplicationBuilder builder)
  {
    return builder.UseMiddleware<MeningMiddleware>();
  }
}
