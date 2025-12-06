var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options =>
{
  options.Limits.MaxRequestBodySize = 10 * 1024 * 1024;

  options.AddServerHeader = false;
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

if (builder.Environment.IsDevelopment())
{
  builder.Services.AddSwaggerGen();
}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseDeveloperExceptionPage();
  app.UseSwagger();
  app.UseSwaggerUI();
}
else
{
  app.UseExceptionHandler("/Error");

  app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/", () =>
{
  Results.Content("Salom, ASP.NET CORE ilovasi ishlamoqda");
});

app.MapControllers();
app.Run();


// var builder = WebApplication.CreateBuilder();

// var app = builder.Build();

// app.MapGet("/", () =>
// {
//   return "Assalomu alaykum. Bu mening birinchi minimal web api";
// });

// app.Run();

