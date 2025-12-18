using Microsoft.AspNetCore.Mvc;
using MyApi.Filters;

var builder = WebApplication.CreateBuilder();

builder.Services.AddControllers();
builder.Services.AddScoped<ApiCheck>();

var app = builder.Build();

app.MapControllers();

app.Run();
