using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Project4.Models;
using Project4.Data;
using Project4.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IPortfolioService, PortfolioService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Home/Error");
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}
else
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Portfolio}/{action=Index}/{id?}")
    .WithStaticAssets();


app.MapGet("api/portfolio", async ([FromServices] IPortfolioService service) =>
{
  var items = await service.GetAllAsync();
  return Results.Ok(items);
});

app.MapPost("api/portfolio", async (PortfolioItem item, [FromServices] IPortfolioService service) =>
{
  await service.AddAsync(item);
  return Results.Created($"/api/portfolio/{item.Id}", item);
});

app.Run();
