using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
          PizzaViewModel pizzaViewModel = new PizzaViewModel();
          pizzaViewModel.Pizzas.Add(new Domain.Models.CheesePizza());
            return View();
        }

        public IActionResult OrderCheesePizza()
        {
          CheesePizza cheesePizza = new CheesePizza();
          ViewBag.OrderType="Cheese Pizza";
          return RedirectToAction("Index","Order",new{orderType="Cheese Pizza", crust = cheesePizza.Crust, size = cheesePizza.Size, name = cheesePizza.Name, price = cheesePizza.Price});

        }
        public IActionResult OrderVeggiePizza()
        {
          VeggiePizza veggiePizza = new VeggiePizza();
          ViewBag.OrderType="Veggie Pizza";

          return RedirectToAction("Index","Order",new{orderType="Veggie Pizza", crust = veggiePizza.Crust, size = veggiePizza.Size, name = veggiePizza.Name, price = veggiePizza.Price});
        }
        public IActionResult OrderPepperoniPizza()
        {
          PepperoniPizza pepperoniPizza = new PepperoniPizza();
          ViewBag.OrderType="Pepperoni Pizza";
          return RedirectToAction("Index","Order",new{orderType="Pepperoni Pizza", crust = pepperoniPizza.Crust, size = pepperoniPizza.Size, name = pepperoniPizza.Name, price = pepperoniPizza.Price});
        }
        public IActionResult OrderHawaiianPizza()
        {
          HawaiianPizza hawaiianPizza = new HawaiianPizza();
          ViewBag.OrderType="Hawaiian Pizza";
          return RedirectToAction("Index","Order",new{orderType="Hawaiian Pizza", crust = hawaiianPizza.Crust, size = hawaiianPizza.Size, name = hawaiianPizza.Name, price = hawaiianPizza.Price});
        }
    }
}
