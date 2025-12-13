namespace Project2.Middlewares;

public class SimpleGuardMiddleware
{
  private readonly RequestDelegate next;

  public SimpleGuardMiddleware(RequestDelegate next) => this.next = next;

  public async Task InvokeAsync(HttpContext context)
  {
    if (!context.Request.Headers.ContainsKey("Allow"))
    {
      context.Response.StatusCode = 403;
      await context.Response.WriteAsync("Kirish mumkin emas");
      return;
    }

    await next(context);
  }
}
