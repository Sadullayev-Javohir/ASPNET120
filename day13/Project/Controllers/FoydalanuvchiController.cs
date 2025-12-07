using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Project.Models;

namespace Project.Controllers;

public class FoydalanuvchiController : Controller
{
  [HttpGet]
  public IActionResult Profil(int id)
  {
    var model = new FoydalanuvchiModel
    {
      Id = id,
      Ism = "Test foydalanuvchi",
      Yosh = 20
    };
    return View(model);
  }

  public IActionResult Details(int id)
  {
    if (id == 0) return NotFound();
    return Content($"Mahsulot ID si: {id}");
  }

  public IActionResult GetJson()
  {
    var data = new {Ism = "iPhone 15", Price = 1200};
    return Json(data);
  }


  [HttpGet]
  public IActionResult Matn(int id)
  {
    string xabar = $"Siz Foydalanuvchi ID: {id} profilini ko'ryapsiz";
    return Content(xabar);
  }
}
