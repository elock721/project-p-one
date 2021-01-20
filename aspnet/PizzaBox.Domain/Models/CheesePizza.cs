using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models

{
  public class CheesePizza : APizzaModel
  {
    // constructor
     public CheesePizza()
     {
       Crust = "Hand Tossed";
       Size = "Regular";
       Name = "Cheese Pizza";
       Price = 8.00;
     }
  }
}
