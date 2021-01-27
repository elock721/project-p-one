using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Factories
{

  // future develpoment
  public class GenericPizzaFactory
  {
    public T Make<T>() where T : APizzaModel, new()
    {
      return new T();
    }
  }
}
