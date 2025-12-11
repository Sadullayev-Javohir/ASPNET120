using System.Reflection;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    // API haqida umumiy ma'lumot
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Mening Super Market API",
        Description = "Bu API mahsulotlarni boshqarish uchun ishlatiladi.",
        Contact = new OpenApiContact
        {
            Name = "Sizning Ismingiz",
            Url = new Uri("https://t.me/sizning_profil")
        }
    });

    // XML kommentlarni ulash
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);
});

builder.Services.AddControllers();

var app = builder.Build();

// Swagger UI – Developmentda yoqiladi
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Market API V1");
    });
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
