var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
  Console.WriteLine("A - kirish");
  await next();
  Console.WriteLine("A - chiqish");
});

app.Use(async (context, next) =>
{
  Console.WriteLine("B - kirish");
  await next();
  Console.WriteLine("B - chiqish");
});

app.MapGet("/", () => "Hello World!");


app.Run(async context =>
{
  Console.WriteLine("C - Terminal");
  await context.Response.WriteAsync("Hello");
});
