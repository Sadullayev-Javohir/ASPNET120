using Microsoft.AspNetCore.Mvc;

namespace CommandLineDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class RunController : Controller
{
  private IConfiguration _config;

  public RunController(IConfiguration config) => _config = config;

  [HttpGet]
  public string Get()
  {
    var mode = _config["RunMode"];
    var port = _config["Port"];

    return $"Mode: {mode}, Port: {port}";
  }
}
