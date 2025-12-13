namespace CustomMiddleware.Middlewares;

public class ApiKeyMiddleware
{
  private readonly RequestDelegate next;

  public ApiKeyMiddleware(RequestDelegate next) => this.next = next;

  public async Task InvokeAsync(HttpContext context)
  {
    if (!context.Request.Headers.TryGetValue("X-API-KEY", out var apiKey) || apiKey != "Secret123")
    {
      context.Response.StatusCode = 401;
      await context.Response.WriteAsync("Invalid Api Key");
      return;
    }

    await next(context);
  }
}
