using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Handin3
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza myPizza = new Margherita();
            Console.WriteLine("A pizza Margherita costs " + myPizza.Cost() + " Kroner without toppings");
            string exit = String.Empty;
            
            do
            {
                Console.WriteLine("***********************************************\n" +
                                  "Would you like to add something to your pizza? \n" +
                                  "1. Pepperoni     10 Kr. Ekstra\n" +
                                  "2. Pineapple     5 Kr. Ekstra\n" +
                                  "3. Rucola        5 Kr. Ekstra\n" +
                                  "4. Kebab         10 Kr. Ekstra\n" +
                                  "5. No more topping\n" +
                                  "***********************************************\n");

                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Adds pepperoni to your pizza");
                        myPizza = new Pepperoni(myPizza);
                        break;
                    case "2":
                        Console.WriteLine("Adds pineapple to your pizza");
                        myPizza = new Pineapple(myPizza);
                        break;
                    case "3":
                        Console.WriteLine("Adds rucola to your pizza");
                        myPizza = new Rucola(myPizza);
                        break;
                    case "4":
                        Console.WriteLine("Adds kebab to your pizza");
                        myPizza = new Kebab(myPizza);
                        break;
                    case "5":
                        Console.WriteLine(myPizza.GetDescription()+ "\ncosts " + myPizza.Cost() + " Kroner");
                        Console.ReadKey();
                        exit = "q";
                        break;
                    default:
                        Console.WriteLine("Please enter a number between 1-6\n");
                        break;
                }
            }while(exit != "q");
        }
    }
}
