using CustomMiddleware.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<LoggingMiddleware>();

app.UseMiddleware<RequestTimingMiddleware>();

app.UseMiddleware<ApiKeyMiddleware>();

app.MapGet("/", () => "Xush kelibsiz! API key to'g'ri bo'lsa ishlaydi");
app.MapGet("/admin", () => "Admin sahifasi");

app.Run();
