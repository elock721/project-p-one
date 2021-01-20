using System.Collections.Generic;
using System.Linq;

using PizzaBox.Domain.Models;

namespace PizzaBox.Storage
{
  public class SqlClient
  {
    private readonly PizzaBoxContext _db = new PizzaBoxContext();

    public SqlClient()
    {
    }


    // creating user in db here
    public void SaveUser(User user)
    {
      _db.Add(user); // git add
      _db.SaveChanges(); // git commit
    }


    public List<Store> ReadStores()
    {
      return _db.Stores.ToList();
    }

    public void Save(Store store)
    {
      _db.Add(store); // git add
      _db.SaveChanges(); // git commit
    }

    public void CreateStore()
    {
      Save(new Store());
    }

    public Store FetchStore(string input)
    {
      return _db.Stores.FirstOrDefault(s => s.Name == input);
    }

    public List<User> FetchUsers()
    {
      // return _db.Users.ToList();
      var u = _db.Users.ToList();
      return u;

    }

    // Save Order to order table
    public void SaveOrder(Order order)
    {
      _db.Add(order);
      _db.SaveChanges();
    }
  }

}
