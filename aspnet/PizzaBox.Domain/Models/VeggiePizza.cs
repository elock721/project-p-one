using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models

{
  public class VeggiePizza : APizzaModel
  {
    // constructor
     public VeggiePizza()
     {
       Crust = "Hand Tossed";
       Size = "Regular";
       Toppings = new List<string>{"Onions","Bell Pepper", "Mushroom"};
       Name = "Veggie Pizza";
       Price = 10.00;
     }
  }
}


