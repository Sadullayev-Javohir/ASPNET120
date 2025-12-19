using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<AppConfig>(builder.Configuration.GetSection("MainSettings"));

var app = builder.Build();

app.MapGet("/", (IOptionsSnapshot<AppConfig> config) =>
{
  return $"App Name: {config.Value.AppName}, Theme: {config.Value.Theme}";
});
