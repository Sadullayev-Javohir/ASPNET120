using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Services;

namespace MyPortfolio.Controllers;

public class HomeController : Controller
{
  private readonly PortfolioService _portfolioService;

  public HomeController(PortfolioService portfolioService) => _portfolioService = portfolioService;

  public IActionResult Index()
  {
    var portfolio = _portfolioService.GetPortfolioData();
    return View(portfolio);
  }
}
