using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin3
{
    class Pineapple : ToppingDecorator
    {
        private Pizza pizza;

        public Pineapple(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string getDescription()
        {
            string msg = "Added pineapple, the new price:";
            return msg;
        }
        public override double Cost()
        {
            return pizza.Cost() + 10;
        }

        //public override string getDescription()
        //{
        //    return "Added Pineapple + 10 kr";
        //}
    }
}
