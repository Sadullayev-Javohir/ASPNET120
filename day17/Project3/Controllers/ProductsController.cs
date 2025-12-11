using Microsoft.AspNetCore.Mvc;
using Project3.Models;

namespace Project3.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
  private static readonly List<Product> Products = new List<Product>
  {
    new Product {Id = 1, Name = "Laptop", Price = 1200},
    new Product {Id = 2, Name = "Phone", Price = 800}
  };


  [HttpGet]
  public IActionResult GetAll() => Ok(Products);

  [HttpGet("{id}")]
  public IActionResult GetById(int id)
  {
    var product = Products.FirstOrDefault(p => p.Id == id);

    if (product == null)
    {
      return NotFound($"Product with Id {id} not found");
    }
    return Ok(product);
  }

  [HttpPost]
  public IActionResult Create(Product product)
  {
    product.Id = Products.Count + 1;
    Products.Add(product);
    return CreatedAtAction(nameof(GetById), new {id = product.Id}, product);
  }
}
