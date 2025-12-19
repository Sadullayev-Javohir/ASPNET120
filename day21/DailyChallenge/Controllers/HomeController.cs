using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class HomeController : Controller
{
  private IConfiguration _config;

  public HomeController(IConfiguration config) => _config = config;

  [HttpGet]
  public string Get()
  {
    string adminName = _config["AdminName"];

    return $"AdminName: {adminName}";
  }
}
