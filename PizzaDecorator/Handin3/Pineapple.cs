using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin3
{
    class Pineapple : ToppingDecorator
    {
        private IPizza pizza;

        public Pineapple(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public override string GetDescription()
        {
            string msg = ", pineapple";
            return pizza.GetDescription() + msg;
        }
        public override double Cost()
        {
            
            return pizza.Cost() + 10;
        }

       
    }
}
