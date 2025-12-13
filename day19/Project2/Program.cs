using Project2.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<SimpleGuardMiddleware>();

app.MapGet("/", () => "Xush kelibsiz");

app.Run();
