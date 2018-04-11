using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin3
{
    class Rucola : ToppingDecorator
    {
        private IPizza pizza;

        public Rucola(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public override string GetDescription()
        {
            string msg = "and rucola ";
            return pizza.GetDescription() + msg;
        }
        public override double Cost()
        {
            return pizza.Cost() + 5;
        }
    }
}
