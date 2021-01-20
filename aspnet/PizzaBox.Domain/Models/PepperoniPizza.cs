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
       Name = "Pepperoni Pizza";
       Price = 9.00;
     }
  }
}
