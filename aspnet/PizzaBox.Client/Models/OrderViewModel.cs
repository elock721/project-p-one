using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.Extensions.Configuration;
using PizzaBox.Storage;

namespace PizzaBox.WebClient.Models
{
  public class OrderViewModel
  {
    public List<string> Stores { get; set; } // Where all the stores are saved OUTPUT

    [Required]
    public string Store { get; set; } // Selected Store INPUT

    public OrderViewModel()
    {

    }
  }
}
