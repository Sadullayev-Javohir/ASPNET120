using Microsoft.AspNetCore.Mvc;
using GoodWay.Models;

namespace GoodWay.Controllers;

public class UserController : Controller
{
  public IActionResult ProfileGood()
  {
    var user = new UserProfileViewModel
    {
      FullName = "Javohir",
      Email = "javohir@gmail.com",
      Age = 25,
      IsPremiumUser = true
    };

    return View(user);
  }
}
