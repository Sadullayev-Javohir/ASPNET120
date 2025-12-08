using Microsoft.AspNetCore.Mvc;
using BookStore1.Models;

namespace BookStore1.Controllers;

public class BookController : Controller
{
  public IActionResult Details()
  {
    var book = new BookViewModel
    {
      Title = "C# asoslari",
      Author = "Javlon Abduvaliyev",
      Price = 99999.99m,
      IsBestseller = true
    };

    return View(book);
  }
}
