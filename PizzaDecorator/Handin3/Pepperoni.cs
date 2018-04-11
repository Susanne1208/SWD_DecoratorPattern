﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin3
{
    class Pepperoni : ToppingDecorator
    {
        private Pizza pizza;

        public Pepperoni(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string getDescription()
        {
            string msg = "and pepperoni ";
            return pizza.getDescription() + msg;
        }
        public override double Cost()
        {
            return pizza.Cost() + 10;
        }
    }
}
