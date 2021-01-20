using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;


namespace PizzaBox.Domain.Models
{
    public class User : AEntity
    {
        public string Name { get; set; }
        public long SelectedStore { get; set; }

        public User()
        {
        }
    }
}
