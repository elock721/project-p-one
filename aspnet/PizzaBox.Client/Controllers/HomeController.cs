using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PizzaBox.Storage.PizzaBoxContext _ctx;
        private readonly PizzaBox.Storage.SqlClient sqlClient;

        public HomeController(ILogger<HomeController> logger,PizzaBox.Storage.PizzaBoxContext dbContext)
        {
            _logger = logger;
            _ctx = dbContext;
            sqlClient = new Storage.SqlClient();
        }

        public IActionResult Index()
        {
          //This page loads a welcome page where we have our small form to enter user data
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Once form is submitted, this action saves the user to database and navigates to Store index page
        [HttpPost]
        public IActionResult SaveUser(PizzaBox.Domain.Models.User model)
        {
          // retreive last saved user from users table
          var user = _ctx.Users.Select(u=>u).OrderByDescending(o=>o.EntityId).FirstOrDefault();

          // assignment of PK value
          if(user!=null)
          {
            model.EntityId=user.EntityId+1;
          }
          else{
            model.EntityId=1;
          }
          model.SelectedStore=1;

          sqlClient.SaveUser(model);
          return RedirectToAction("Index", "Store");
        }
    }
}
