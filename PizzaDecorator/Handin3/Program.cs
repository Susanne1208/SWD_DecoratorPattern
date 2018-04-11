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
            //Pizza myPizza = new Margherita();
            //Console.WriteLine(myPizza.getDescription() + myPizza.Cost());

            string response;
            string responseP;
            Pizza myPizza1 = new Margherita();

            Console.WriteLine("Would you like to add something to your pizza? (y/n)");
            response = Console.ReadLine();
            if (response == "y")
            {
                do ()
                Console.WriteLine("Which topping");

            }
            else
            {

            }
            switch (response)
            {
                case "y":
                    Console.WriteLine("Pepperoni or Pineapple?");
                    responseP = Console.ReadLine();
                    if (responseP == "pepperoni")   
                    {
                        myPizza1 = new Pepperoni(myPizza1);
                        Console.WriteLine(myPizza1.getDescription() + myPizza1.Cost());
                    }

                    if (responseP == "pineapple")
                    {
                        myPizza1 = new Pineapple(myPizza1);
                        Console.WriteLine(myPizza1.getDescription()+myPizza1.Cost());
                    }
                    break;
                case "n":
                    break;
                default:
                    Console.WriteLine("Write 'y' or 'n' to continue");
                    break;
            }

        }

        
    }
}
