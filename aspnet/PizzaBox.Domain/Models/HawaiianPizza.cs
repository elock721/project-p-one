using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models

{
  public class HawaiianPizza : APizzaModel
  {
    // constructor
     public HawaiianPizza()
     {
       Crust = "Hand Tossed";
       Size = "Regular";
       Toppings = new List<string>{"Pineapple","Ham"};
       Name = "Hawaiian Pizza";
       Price = 10.00;
     }
  }
}
