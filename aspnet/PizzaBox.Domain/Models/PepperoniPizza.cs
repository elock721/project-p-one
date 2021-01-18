using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models

{
  public class PepperoniPizza : APizzaModel
  {
    // constructor
     public PepperoniPizza()
     {
       Crust = "Hand Tossed";
       Size = "Regular";
       Toppings = new List<string>{"Pepperoni"};
       Name = "Pepperoni Pizza";
       Price = 10.00;
     }
  }
}
