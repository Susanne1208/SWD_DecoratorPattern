using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Handin3
{
    // PlainPizza
    public class Margherita : IPizza
    {
        public string GetDescription()
        {
            return "Pizza with tomatosause and cheese "; 
        }

        public double Cost()
        {
            return 50.00;
        }
    }
}
