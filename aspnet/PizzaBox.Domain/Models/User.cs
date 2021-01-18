using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Abstracts.Models;

namespace PizzaBox.Domain.Models
{
    public class User : AEntity
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
        public Store SelectedStore { get; set; }

        public User()
        {
          Orders = new List<Order>();
        }
    }
}
