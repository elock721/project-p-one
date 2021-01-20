using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Client.Models
{
  public class PizzaViewModel
  {
    public List<APizzaModel> Pizzas { get; set; }

    public PizzaViewModel()
    {
      Pizzas = new List<APizzaModel>();
    }
  }
}
