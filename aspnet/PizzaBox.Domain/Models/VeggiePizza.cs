using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models

{
  public class VeggiePizza : APizzaModel
  {
    // constructor
     public VeggiePizza()
     {
       Crust = "Thin Crust";
       Size = "Medium";
       Name = "Veggie Pizza";
       Price = 10.00;
     }
  }
}


