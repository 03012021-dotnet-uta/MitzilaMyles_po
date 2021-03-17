using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class Order
  {
    public AStore store;
    public Customer customer;
    public List<APizza> Pizzas { get; set; }
  }

}

