using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Store : AEntity
    {
      public string Name { get; set; }
      public string Address { get; set; }
      public List<Order> Orders { get; set; }
    }
}
