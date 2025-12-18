using Project5.Extensions;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMeningSoqchim();

app.MapGet("/", () => "Salom, Saytga Xush kelibsiz");

app.Run();
