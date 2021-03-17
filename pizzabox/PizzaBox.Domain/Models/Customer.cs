namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class Customer
  {
     public string Name { get; set; }
     public Customer (string customerName){
       Name = customerName;  
   }

  }
}
