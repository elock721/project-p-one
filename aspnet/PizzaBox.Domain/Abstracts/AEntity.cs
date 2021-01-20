using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class AEntity
  {
    // auto increment in the DB
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long EntityId { get; set; }

    protected AEntity()
    {

    }
  }
}
