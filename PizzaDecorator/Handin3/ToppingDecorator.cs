using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin3
{
    public abstract class ToppingDecorator : IPizza
    {
        public abstract string GetDescription();

        public abstract double Cost();
    }
}
