using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models

{
  public class HawaiianPizza : APizzaModel
  {
    // constructor
     public HawaiianPizza()
     {
       Crust = "Brooklyn Style";
       Size = "Extra Large";
       Name = "Hawaiian Pizza";
       Price = 11.00;
     }
  }
}
