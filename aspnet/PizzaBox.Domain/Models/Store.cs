using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts.Models
{
    public class Store : AEntity
    {
      public string Name { get; set; }
      public string Address { get; set; }
      public List<Order> Orders { get; set; }
    }
}
