using System.Diagnostics;

namespace CustomMiddleware.Middlewares;

public class RequestTimingMiddleware
{
  private readonly RequestDelegate next;

  public RequestTimingMiddleware(RequestDelegate next) => this.next = next;

  public async Task InvokeAsync(HttpContext context)
  {
    var watch = Stopwatch.StartNew();
    await next(context);
    watch.Stop();
    Console.WriteLine($"Request {context.Request.Path} took {watch.ElapsedMilliseconds}");
  }
}
