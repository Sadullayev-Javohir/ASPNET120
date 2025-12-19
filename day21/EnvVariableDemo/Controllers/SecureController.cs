using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class SecureController : ControllerBase
{
  private IConfiguration _config;

  public SecureController(IConfiguration config) => _config = config;

  public string Get()
  {
    string db_pswrd = _config["Database:Password"];
    return $"Database password: {db_pswrd}";
  }
}
