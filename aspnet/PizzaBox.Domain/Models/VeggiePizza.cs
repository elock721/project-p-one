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
       Name = "Veggie Pizza";
       Price = 10.00;
     }
  }
}


