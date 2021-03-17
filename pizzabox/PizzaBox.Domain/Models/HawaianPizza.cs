using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class HawaianPizza : APizza
  {
    protected override void AddCrust()
    {
        Crust = new Crust();
     //Name = "thin";
    }

    protected override void AddSize()
    {
       Size = new Size();
    }

    protected override void AddToppings()
    {
       Toppings = new List<Topping>
      {
       new Topping("Ham", 1.00M),
       new Topping("Pineapple", 0.25M),
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
     public HawaianPizza(){
         Name = "Hawaian Pizza";
     }

     public HawaianPizza(Crust crust,  Size s)
     {
         Name = "Hawaian Pizza";
         Crust.Name = crust.Name;
         Crust.Price = crust.Price;
         Size.Name = s.Name;
         Size.Price = s.Price;

     }
  }
}
