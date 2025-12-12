using System.IO.Pipes;
using Microsoft.AspNetCore.Mvc;
using Project4.Services;

namespace Project4.Controllers;

public class PortfolioController : Controller
{
  private readonly IPortfolioService _service;

  public PortfolioController(IPortfolioService service) => _service = service;

  public async Task<IActionResult> Index()
  {
    var items = await _service.GetAllAsync();
    return View(items);
  }
}
