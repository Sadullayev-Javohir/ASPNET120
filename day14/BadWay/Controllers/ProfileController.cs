using Microsoft.AspNetCore.Mvc;
using BadWay.Models;

namespace BadWay.Controllers;

public class ProfileController : Controller
{
  public IActionResult Index()
  {
    ViewBag.UserName = "Javohir";
    ViewBag.UserEmail = "javohir@gmail.com";
    ViewBag.UserAge = 25;

    return View();
  }
}
