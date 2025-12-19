using ConfigDemo.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<MySettings>(builder.Configuration.GetSection("GameSettings"));

builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();
