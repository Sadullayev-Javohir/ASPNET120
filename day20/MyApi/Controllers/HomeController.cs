using Microsoft.AspNetCore.Mvc;
using MyApi.Filters;

namespace MyApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[ServiceFilter(typeof(ApiCheck))]
public class HomeController : Controller
{
  [HttpGet]
  public IActionResult Get() => Ok("Api is secured with an API key");
}
