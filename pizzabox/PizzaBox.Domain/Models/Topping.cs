namespace PizzaBox.Domain.Models
{
  public class Topping : AComponent
  {
    public Topping(){//Default constructor
      Name= "";
      Price = 0;
    }
    public Topping(string n, decimal p){// second constructor that is passing two parameters
      Name = n;
      Price = p;
    }
  }
}