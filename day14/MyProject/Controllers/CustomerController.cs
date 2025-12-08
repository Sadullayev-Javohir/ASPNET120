using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.Controllers;

public class CustomerController : Controller
{
  public IActionResult Details(int id)
  {
    var orders = new List<OrderViewModel>
    {
      new OrderViewModel {OrderId = 101, Date = DateTime.Now.AddDays(-5), TotalAmount=120.50m, IsPaid = true},
      new OrderViewModel { OrderId = 102, Date = DateTime.Now.AddDays(-2), TotalAmount = 85.00m, IsPaid = false },
      new OrderViewModel { OrderId = 103, Date = DateTime.Now.AddDays(-1), TotalAmount = 42.30m, IsPaid = true }
    };

    var customer = new CustomerDetailViewModel
    {
      FullName = "Ali Valiyev",
      Email = "ali@gmail.com",
      Phone = "+998 90 123 45 67",
      Orders = orders,
      PageTitle = "Mijozning batafsil ma'lumotlari"
    };

    return View(customer);
  }
}
