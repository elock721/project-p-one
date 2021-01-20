using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing
{
  public class StoreTest
  {
    [Fact]
    private void Test_StoreExists()
    {
      // arrange
      var sut = new Store(); // inference
      Store sut1 = new Store(); // memory allocation

      // act
      var actual = sut;

      // assert
      Assert.IsType<Store>(actual);
      Assert.NotNull(actual);
    }
  }
}
