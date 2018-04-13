using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin3
{
    class Kebab : ToppingDecorator
    {
        private IPizza pizza;

        public Kebab(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public override string GetDescription()
        {
            string msg = ", kebab";
            return pizza.GetDescription() + msg;
        }
        public override double Cost()
        {
            return pizza.Cost() + 10;
        }
    }
}
