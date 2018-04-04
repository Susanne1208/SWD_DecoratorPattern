using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Handin3
{
    // PlainPizza
    public class Margherita : Pizza
    {
        public string getDescription()
        {
            return "Pizza with tomatosause and cheese"; 
            //throw new NotImplementedException();
        }

        public double getCost()
        {
            
            Console.WriteLine("The price: " + 60.00);
            return 60.00;
            //throw new NotImplementedException();
        }
    }
}
