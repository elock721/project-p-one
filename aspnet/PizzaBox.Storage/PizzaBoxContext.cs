using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Abstracts.Models;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage
{
  public class PizzaBoxContext : DbContext
  {
    public DbSet<Store> Stores { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<APizzaModel> Pizzas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("Server=elpizzaworlddb.database.windows.net; Initial Catalog=p1db;User Id=sqladmin;Password=Password12345");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Store>().HasKey(s => s.EntityId);
      builder.Entity<User>().HasKey(u => u.EntityId);
      builder.Entity<Order>().HasKey(o => o.EntityId);
      builder.Entity<APizzaModel>().HasKey(p => p.EntityId);

      builder.Entity<Store>().Property(p => p.EntityId).ValueGeneratedNever();
      builder.Entity<User>().Property(p => p.EntityId).ValueGeneratedNever();
      builder.Entity<Order>().Property(p => p.EntityId).ValueGeneratedNever();
      builder.Entity<APizzaModel>().Property(p => p.EntityId).ValueGeneratedNever();

      SeedData(builder);
    }

    private void SeedData(ModelBuilder builder)
    {
      builder.Entity<Store>().HasData(new List<Store>
        {
          new Store() { EntityId = 1, Name = "Home Slice"},
          new Store() { EntityId = 2, Name = "Pinthouse Pizza Co"}
        });
    }
  }
}
