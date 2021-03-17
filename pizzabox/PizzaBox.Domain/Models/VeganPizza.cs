using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class VeganPizza : APizza
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
        new Topping("Black olives", 1.00M),
        new Topping("White Truffles", 2.00M)
      };
    }
    public  override void CalculateTotal(){
      decimal toppingTotal = 0;
      foreach(var t in Toppings){

      }
      Total = toppingTotal + Size.Price + Crust.Price;
    }
    public VeganPizza(){
       Name = "VeganPizza";
    }
    public VeganPizza (Crust crust,  Size s){
      Name = "Vegan Pizza";
      Crust.Name = crust.Name;
      Crust.Price = crust.Price;
      Size.Name = s.Name;
      Size.Price = s.Price;
    }
  }
}
