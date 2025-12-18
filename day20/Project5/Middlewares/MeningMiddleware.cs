using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;

namespace Project5.Middlewares;

class MeningMiddleware
{
  private readonly RequestDelegate _next;

  public MeningMiddleware(RequestDelegate next) => _next = next;

  public async Task InvokeAsync(HttpContext context)
  {
    Console.WriteLine($"Kirish: Foydalanuvchi {context.Request.Path} ga kirayapti");

    await _next(context);

    Console.WriteLine($"Qaytish: {context.Request.Path} dan chiqib ketdi.");
  }
}
