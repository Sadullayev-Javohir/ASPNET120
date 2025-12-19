using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class HomeController : Controller
{
  private IConfiguration _config;

  public HomeController(IConfiguration config) => _config = config;

  public string Get()
  {
    string siteName = _config["SiteSettings:SiteName"],
    pageSize = _config["SiteSettings:PageSize"];

    return $"Site: {siteName}, Page: {pageSize}";

  }
}
