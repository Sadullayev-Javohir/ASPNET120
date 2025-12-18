// using System.Formats.Asn1;

// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// app.Use(async (context, next) =>
// {
//   Console.WriteLine("1-Soqchi. Salom kiring");

//   await next();

//   Console.WriteLine("1-soqchi. Xayr yaxshi boring");
// });

// app.Use(async (context, next) =>
// {
//   Console.WriteLine("2-soqchi: Hujjat joyida, o'tavering");
//   await next();
//   Console.WriteLine("2-soqchi: Muhr bosib berdim");

// });

// app.MapGet("/", () =>
// {
//   Console.WriteLine("Podshoh: Arznomani qabul qildim");
//   return "Mana bu Podshohnnig javobi";
// });

// app.Run();



var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// 1-SOQCHI
app.Use(async (context, next) =>
{
    // QAYSI YO'LGA KELGANINI KO'RSATAMIZ:
    Console.WriteLine($"➡️ 1-Soqchi: Keldingiz: {context.Request.Path}");
    await next();
    Console.WriteLine($"⬅️ 1-Soqchi: Kuzatdim: {context.Request.Path}");
});

// 2-SOQCHI
app.Use(async (context, next) =>
{
    Console.WriteLine("➡️ 2-Soqchi: O'tkazdim.");
    await next();
    Console.WriteLine("⬅️ 2-Soqchi: Qaytardim.");
});

// PODSHOH
app.MapGet("/", () =>
{
    Console.WriteLine("👑 Podshoh: Salom!");
    return "Hello World";
});

app.Run();
