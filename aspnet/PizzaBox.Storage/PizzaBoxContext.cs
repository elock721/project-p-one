using System;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain;

namespace PizzaBox.Storage
{
    public class PizzaBoxContext : DbContext
    {
      public DbSet<Store> Stores { get; set; }
      public DbSet<User> Users { get; set; }
      public DbSet<Order> Orders { get; set; }
      public DbSet<Pizza> Pizzas { get; set; }
    }
}
