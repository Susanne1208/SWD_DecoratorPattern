using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin3
{
    class Pepperoni : ToppingDecorator
    {
        private IPizza pizza;

        public Pepperoni(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public override string GetDescription()
        {
            string msg = ", pepperoni";
            return pizza.GetDescription() + msg;
        }
        public override double Cost()
        {
            return pizza.Cost() + 10;
        }
    }
}
