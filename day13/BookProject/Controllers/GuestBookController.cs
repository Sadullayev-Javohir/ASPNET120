using Microsoft.AspNetCore.Mvc;
using BookProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookProject.Controllers;

public class GuestBookController : Controller
{
  private static List<Guest> _guests = new List<Guest>();

  public IActionResult Index() => View(_guests.OrderByDescending(x => x.Date).ToList());

  [HttpGet]
  public IActionResult Add() => View();

  [HttpPost]
  public IActionResult Add(Guest guest)
  {
    if (!ModelState.IsValid) return View(guest);

    guest.Id = _guests.Count + 1;
    guest.Date = DateTime.Now;

    _guests.Add(guest);

    return RedirectToAction("Index");
  }
}
