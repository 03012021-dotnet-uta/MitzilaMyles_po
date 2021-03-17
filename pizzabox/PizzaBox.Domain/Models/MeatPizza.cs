using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class MeatPizza : APizza
  {
    protected override void AddCrust()
    {
       Crust c = new Crust();
       
    }

    protected override void AddSize()
    {
       Size s = new Size();
    }
    
 protected override void AddToppings()
    {
       Toppings = new List<Topping>
      {
       new Topping("meat", 1.00M),
       new Topping ("Cheese", 0.50M)
        };
    }
     public override void CalculateTotal()
     {
       decimal toppingTotal = 0;
       foreach(var t in Toppings)
       {
           toppingTotal += t.Price;

       }
      Total = toppingTotal + Size.Price + Crust.Price; 

     }
     public MeatPizza(){
         Name = "Meat Pizza";
     }

     public MeatPizza(Crust crust,  Size s)
     {
         Name = "Meat Pizza";
         Crust.Name = crust.Name;
         Crust.Price = crust.Price;
         Size.Name = s.Name;
         Size.Price = s.Price;

     }
  }
}
