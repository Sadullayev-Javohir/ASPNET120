using Microsoft.AspNetCore.Mvc;
using MyProject.Dtos;

namespace MyProject.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : Controller
{
  /// <summary>
  /// Yangi mahsulot qo'shish.
  /// </summary>
  /// Namuna so'rov
  ///
  /// POST /api/products
  /// {
  ///   "name": "Iphone 15"
  ///   "price": 1200
  /// }
  ///
  /// </remarks>
  ///
  /// <response code="201">Muvvaffaqiyatli yaratildi </response>
  /// <response code="400">Ma'lumotlar noto'g'ri</response>

  [HttpPost]
  [ProducesResponseType(StatusCodes.Status201Created)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public IActionResult CreateProduct([FromBody] ProductDto product)
  {
    if (!ModelState.IsValid) return BadRequest(ModelState);

    return CreatedAtAction(nameof(GetById), new {id = 1}, product);
  }

  /// <summary>
  /// Mahsulotni ID bo'yicha olish.
  /// </summary>
  ///

  [HttpGet("{id:int}")]
  public IActionResult GetById(int id)
  {
    var fake = new ProductDto {Name = "Iphone 15", Price = 1200};
    return Ok(fake);
  }
}
