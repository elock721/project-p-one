using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Factories;

namespace PizzaBox.Domain.Models
{

  // future development
  public class Order : AEntity
  {
    //creating diff instances of pizzas
    private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();

    public List<APizzaModel> Pizzas { get; set; }

    public Order()
    {
      Pizzas = new List<APizzaModel>(){};
    }

    // future development
    public void MakeCheesePizza()
    {
      Pizzas.Add(_pizzaFactory.Make<CheesePizza>());
    }
    public void MakeVeggiePizza()
    {
      Pizzas.Add(_pizzaFactory.Make<VeggiePizza>());
    }
    public void MakePepperoniPizza()
    {
      Pizzas.Add(_pizzaFactory.Make<PepperoniPizza>());
    }
    public void MakeHawaiianPizza()
    {
      Pizzas.Add(_pizzaFactory.Make<VeggiePizza>());
    }
  }
}
