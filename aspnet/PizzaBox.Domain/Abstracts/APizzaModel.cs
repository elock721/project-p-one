using System.Collections.Generic;

namespace PizzaBox.Domain.Abstracts
{
  public class APizzaModel : AEntity
  {

    // properties
    public string Crust { get; set; }
    public string Size { get; set; }
    public double Price { get; set; }
    public string Name { get; set; }

    // general constructor
    protected APizzaModel()
    {

    }
  }
}

