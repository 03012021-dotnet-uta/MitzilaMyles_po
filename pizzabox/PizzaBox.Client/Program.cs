using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;

namespace PizzaBox.Client
{
  /// 
  /// 
  /// </summary>
  class Program
  {
    /// <summary>
    /// 
    /// </summary>
    
    static void Main(string[] args)
    {
      starting();
      
    }

    /// <summary>
    /// 
    /// </summary>
    public static void PlaywithStore()
    {
      // foreach (var store in StoreSingleton.Instance.Stores)
      // {
      //   Console.WriteLine(store);
      // }

      StoreSingleton.Instance.Seeding();
      StoreSingleton.Instance.PizzaSeeding();
    }


    public static void starting()
    {
      var ss = StoreSingleton.Instance;

      ss.Seeding();

      // print all the stores available, must be from file or db
      var storeCount = 1;
      
      foreach (var item in ss.Stores)
      {
        System.Console.WriteLine(storeCount + ") " + item);
        storeCount ++;
      }
       System.Console.WriteLine ("Please chose the number of the store you want: ");
       //select a store
      var input = Console.ReadLine();
      switch (input)
      {
        case "1":
           var storeName = ss.Stores[0].Name; 
           System.Console.WriteLine(storeName);
         
          break;

        case "2":
          
         storeName = ss.Stores[1].Name; 
           System.Console.WriteLine(storeName);
         
          break;

       case "3":
           storeName = ss.Stores[2].Name; 
           System.Console.WriteLine(storeName);
         
          break;


         case "4":
           storeName = ss.Stores[3].Name; 
           System.Console.WriteLine(storeName);
         
          break;

        default: 
         Console.WriteLine("Please select an option from the list. ");
        //  AsACustomer();
         break;
       }
      /////////////////////////////////////////////////////////////////////
      System.Console.WriteLine("Please enter customer name: ");
       var customerName = Console.ReadLine();
       Customer customer = new Customer(customerName);

      
       var pizzaSel = 1;

      while (pizzaSel != 4){
        System.Console.WriteLine ("1.Add a pizza");
        System.Console.WriteLine ("2.View Cart");
        System.Console.WriteLine ("3. View Order History");
        System.Console.WriteLine ("Exit");

        pizzaSel= int.Parse(System.Console.ReadLine());
      
       
       ///Place an order
      
       switch (pizzaSel)
      {
        case 1:
          PizzaSeeding(); // Pizza menu bring it from Singleton?
        // Order();
          break;

        case 2:
          //viewCart();
          break;

       case 3:
           
         // orderCheck();
          break;

        default :
         Console.WriteLine("Please select an option from the list. ");
          //AsACustomer();
         break;
       }
    }
    }  

         public static void  PizzaSeeding() //method
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
        hawaian.Crust = new Crust( ){
          Name = "thin",
          Price = 2.50M
        };
          hawaian.Size = new Size (){
          Name = "small",
          Price = 5.00M
          };

          hawaian.Toppings = new List<Topping>(){
            new Topping("Ham", 1.00M),
            new Topping("Pineapple", 0.25M),
            new Topping ("Cheese", 0.50M)
          };
          List<APizza> d  = new List<APizza>();
          d.Add(meat);
          d.Add(hawaian);
          d.Add(vegan);


             var dCount = 1;
          foreach( var display in d){ // displaying the pizzas for the customer to chose
              System.Console.WriteLine(dCount + ") " + display.Name);
              dCount ++; 
          }
          System.Console.WriteLine("Please a chose a number: ");
           var pizzaNum = System.Console.ReadLine();
      }
          public static void viewCart(List<APizza> cart){
             var pizzaTotal = 0.0M;
             Console.WriteLine ("List of Pizza that you ordered: ");  
             foreach(var p in cart){
               
               p.CalculateTotal();
               pizzaTotal += p.Total;
               System.Console.WriteLine("{0} : {1}",p.Name, p.Total );
             }

              System.Console.WriteLine("Subtotal: {0}", pizzaTotal);

          }
              public static void orderCheck(List<APizza> cart, string s)
              {
                //Console.WriteLine ("Would you like to checkout?" \n1) yes \n2) no \n3) I want to edit)
                var pizzaSel = int.Parse(Console.ReadLine());

                if(pizzaSel == 1){

                Console.WriteLine("Please enter your name: ");
                var  custName = Console.ReadLine();
                Console.WriteLine("Please enter your email: ");
                var custEmail = Console.ReadLine();

               // Customer cust = new Customer(custName, custEmail);
                //Order userOrder = new Order (cart, s, cust);
                //var total = userOrder.calcTotal();
                //userOrder.Total = total;
                //userOrder.SaveOrderToXML(userOrder);
                //Console.WriteLine("Your total is {0}. Thank you {1} for ordering!" , total, custName);
                //cust.Orders.Add(userOrder); 

                }
                else{
                  Console.WriteLine("Returning you to main menu.....");
                }
              }
              public static void ViewOrderHistory(){

              }

              public static void editCart(List<APizza> cart){

              }
      }
    }

   
      
      
      

    
  

