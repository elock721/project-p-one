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
    public class StoreController : Controller
    {


        public IActionResult Index()
        {
          return View("Index");
        }
    }
}
