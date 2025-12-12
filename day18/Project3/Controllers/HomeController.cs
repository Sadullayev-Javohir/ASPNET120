using Microsoft.AspNetCore.Mvc;
using Project3.Services;

namespace Project3.Controllers;

public class HomeController : Controller
{
  private readonly PortfolioService _portfolioService;

  public HomeController(PortfolioService portfolioService) => _portfolioService = portfolioService;

  public IActionResult Index()
  {
    var data = _portfolioService.GetPortfolioData();
    return View(data);
  }
}
