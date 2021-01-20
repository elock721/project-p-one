using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Domain.Models;
using PizzaBox.WebClient.Models;
using PizzaBox.Domain.Abstracts;


namespace PizzaBox.Client.Orders
{
    public class OrderController : Controller
    {

      public IActionResult Index(string orderType, string crust, string size, string name, decimal price)
      {
        ViewBag.OrderType = orderType;
        ViewBag.Crust = crust;
        ViewBag.Size = size;
        ViewBag.Name = name;
        ViewBag.Price = price;
        return View();
      }
    }
}
