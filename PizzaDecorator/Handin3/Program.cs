using System;
using System.Collections.Generic;
using System.Linq;
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

            Pizza myPizza1 = new Margherita();
            myPizza1=new Pineapple(myPizza1);
            Console.WriteLine(myPizza1.getDescription() + myPizza1.Cost());
        }
    }
}
