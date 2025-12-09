using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : Controller
{

  private static List<Product> _products = new List<Product>();

  [HttpGet]
  public ActionResult<IEnumerable<Product>> GetAll() => Ok(_products);

  [HttpGet("{id}")]
  public ActionResult<Product> GetById(int id)
  {
    var product = _products.First(p => p.Id == id);

    if (product == null) return NotFound();

    return Ok(product);
  }

  [HttpPost]
  public ActionResult<Product> Create([FromBody] Product newProduct)
  {
    newProduct.Id = _products.Count + 1;

    _products.Add(newProduct);

    return CreatedAtAction(nameof(GetById), new {id = newProduct.Id}, newProduct);
  }

  [HttpPut("{id}")]
  public IActionResult Update(int id, [FromBody] Product updatedProduct)
  {
    var existingProduct = _products.Find(p => p.Id == id);

    if (existingProduct == null) return NotFound();

    existingProduct.Name = updatedProduct.Name;
    existingProduct.Price = updatedProduct.Price;

    return NoContent();
  }

  [HttpDelete("{id}")]
  public IActionResult Delete(int id)
  {
    var product = _products.Find(p => p.Id == id);

    if (product == null) return NotFound();

    _products.Remove(product);

    return NoContent();
  }
}

