using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin3
{
    class Kebab : ToppingDecorator
    {
        private Pizza pizza;

        public Kebab(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string getDescription()
        {
            string msg = "and kebab ";
            return pizza.getDescription() + msg;
        }
        public override double Cost()
        {
            return pizza.Cost() + 10;
        }
    }
}
