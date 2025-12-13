using App.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Console.WriteLine("🚀 Server ishga tushdi");

// app.UseMiddleware<SchoolGuardMiddleware>();

app.Use(async (context, next) =>
{
  Console.WriteLine($"Request keldi: {context.Request.Path}");
  await next();
  Console.WriteLine($"Response qaytayapti: {context.Request.Path}");
});

app.MapGet("/", () => "Hello World!");

app.Run();
