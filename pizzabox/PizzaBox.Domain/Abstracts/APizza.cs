using System.Collections.Generic;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(MeatPizza))]
  [XmlInclude(typeof(VeganPizza))]
   [XmlInclude(typeof(Size))]
   [XmlInclude(typeof(Crust))]
   [XmlInclude(typeof(Topping))]

  public abstract class APizza
  {
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Topping> Toppings { get; set; }
     public string Name { get; set; }
    
     public decimal Total { get; set; }
    
    public APizza()
    {
      FactoryMethod();
    }

    /// <summary>
    /// 
    /// </summary>
    private void FactoryMethod()
    {
      AddCrust();
      AddSize();
      AddToppings();
    }

    protected abstract void AddCrust();
    protected abstract void AddSize();
    protected abstract void AddToppings();

    public abstract void CalculateTotal();
  }
}
