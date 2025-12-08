using Microsoft.AspNetCore.Mvc;
using BookStore.Models;

namespace BookStore.Controllers;

public class BookController : Controller
{
  public IActionResult Details()
  {
    var book = new BookViewModel
    {
      Title = "C# asoslari",
      Author = "Javlon Murodov",
      Price = 99000,
      IsBestseller = true
    };

    return View(book);
  }
}


