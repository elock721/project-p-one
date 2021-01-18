using System;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class AEntity
  {
    public Guid EntityId { get; }

    protected AEntity()
    {
      // EntityId = DateTime.Now.Ticks;
      EntityId = Guid.NewGuid();
    }
  }
}
