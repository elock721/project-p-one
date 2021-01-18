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
       Toppings = new List<string>{"Cheese"};
       Name = "Cheese Pizza";
       Price = 10.00;
     }
  }
}
