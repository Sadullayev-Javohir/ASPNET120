namespace App.Middlewares;

public class SchoolGuardMiddleware
{
  private readonly RequestDelegate next;

  public SchoolGuardMiddleware(RequestDelegate next) => this.next = next;

  public async Task InvokeAsync(HttpContext context)
  {
    Console.WriteLine("🟡 Qorovul: Tekshiruv boshlandi");

    if (!context.Request.Headers.ContainsKey("Allow"))
    {
      Console.WriteLine("🔴 Qorovul: Ruxsat yo'q!");

      context.Response.StatusCode = 403;
      await context.Response.WriteAsync("Kirish mumkin emas");
      return;
    }
    Console.WriteLine("🟢 Qorovul: Ruxsat bor, o‘ta qol");

    await next(context);

    Console.WriteLine("🔵 Qorovul: Javob qaytdi");
  }
}
