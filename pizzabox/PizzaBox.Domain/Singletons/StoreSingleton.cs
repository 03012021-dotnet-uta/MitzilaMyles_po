using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Domain.Singletons
{
  /// <summary>
  /// 
  /// </summary>
  public class StoreSingleton
  {
    private static StoreSingleton _storeSingleton;
    public List<AStore> Stores { get; set; } // print job
    public List<APizza> Pizzas { get; set; }
    public static StoreSingleton Instance
  {  get{
        if (_storeSingleton == null)
        {
          _storeSingleton = new StoreSingleton(); // printer
        }

        return _storeSingleton;
      }
  }

    /// <summary>
    /// 
    /// </summary>
    private StoreSingleton()
     {
       var fs = new FileStorage();

       if (Stores == null)
      {
         Stores = fs.ReadFromXml<AStore>().ToList();
       }
     }

    public void Seeding()
    {
       var stores = new List<AStore>
      {
        new ChicagoStore(),
        new NewYorkStore(),
        new MiamiStore(),
        new NewJerseyStore()
      };
  

      var fs = new FileStorage();

      //fs.WriteToXml<AStore>(stores);//write my stores to the XML
      Stores = fs.ReadFromXml<AStore>().ToList();//clients will be able to read them
    }
      public List<APizza> PizzaSeeding()
      {
        APizza meat = new MeatPizza();
        meat.Crust = new Crust( ){
          Name = "thin",
          Price = 2.50M
        };
          meat.Size = new Size (){
          Name = "small",
          Price = 5.00M
          };

          meat.Toppings = new List<Topping>(){
            new Topping ("beef meat",1.00M),
            new Topping ("cheese", 1.00M) 
          };

        APizza vegan = new VeganPizza();
        vegan.Crust = new Crust(){
          Name = "rising",
          Price = 3.50M
        };
        vegan.Size = new Size (){
          Name = "small",
          Price = 5.00M
          };

          vegan.Toppings = new List<Topping>{
            new Topping ("broccoli",1.00M),
            new Topping ("cheese",1.00M)
            
          };
           APizza hawaian = new HawaianPizza();
        meat.Crust = new Crust( ){
          Name = "thin",
          Price = 2.50M
        };
          meat.Size = new Size (){
          Name = "small",
          Price = 5.00M
          };

          meat.Toppings = new List<Topping>(){
            new Topping("Ham", 1.00M),
            new Topping("Pineapple", 0.25M),
            new Topping ("Cheese", 0.50M)
          };

        List<APizza> pizzaList = new List<APizza>();
        pizzaList.Add (meat);
        pizzaList.Add (vegan);
        pizzaList.Add (hawaian);

        FileStorage bat = new FileStorage(); //this is the file where the XML will store the pizza files
        bat.WritePizzaToXml (pizzaList);
        return bat.ReadPizzaFromXml <APizza> ().ToList();
        

    /* SINGLETON METHOD WORKFLOW */

    // public static StoreSingleton GetInstance()
    // {
    //   if (_storeSingleton == null)
    //   {
    //     _storeSingleton = new StoreSingleton(); // printer
    //   }

    //   return _storeSingleton;
    // }
  }
}
}

