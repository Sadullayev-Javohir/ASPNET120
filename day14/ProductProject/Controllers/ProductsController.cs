using Microsoft.AspNetCore.Mvc;
using ProductProject.Data;
using ProductProject.Models;

namespace ProductProject.Controllers;

public class ProductsController : Controller
{
  private readonly AppDbContext _context;

  public ProductsController(AppDbContext context) => _context = context;

  [HttpGet]
  public IActionResult Index()
  {
    var products = _context.Products.ToList();
    return View(products);
  }

  [HttpGet]
  public IActionResult Create() => View();

  [HttpPost]
  public IActionResult Create(Product product)
  {
    if (!ModelState.IsValid) return View(product);

    _context.Products.Add(product);
    _context.SaveChanges();

    return RedirectToAction("Index");
  }
}
