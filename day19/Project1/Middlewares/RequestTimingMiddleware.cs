using System.Diagnostics;

namespace Project1.Middlewares;

public class RequestTimingMiddleware
{
  private readonly RequestDelegate next;

  public RequestTimingMiddleware(RequestDelegate next)
  {
    this.next = next;
  }

  public async Task InvokeAsync(HttpContext context)
  {
    var stopwatch = Stopwatch.StartNew();

    await next(context);

    stopwatch.Stop();

    Console.WriteLine($"Request: {context.Request.Path} - {stopwatch.ElapsedMilliseconds} ms");
  }
}
