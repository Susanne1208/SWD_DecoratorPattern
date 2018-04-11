using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin3
{
    class Rucola : ToppingDecorator
    {
        private Pizza pizza;

        public Rucola(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string getDescription()
        {
            string msg = "and rucola ";
            return pizza.getDescription() + msg;
        }
        public override double Cost()
        {
            return pizza.Cost() + 5;
        }
    }
}
