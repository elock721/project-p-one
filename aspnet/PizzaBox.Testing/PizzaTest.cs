using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing
{
  public class PizzaTest
  {
    [Fact]
    private void Test_CheesePizzaExists()
    {
      // arrange
      var sut = new CheesePizza(); // inference
      CheesePizza sut1 = new CheesePizza(); // memory allocation

      // act
      var actual = sut;

      // assert
      Assert.IsType<CheesePizza>(actual);
      Assert.NotNull(actual);
    }
  }
}


