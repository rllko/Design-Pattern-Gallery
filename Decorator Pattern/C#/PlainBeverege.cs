using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class PlainBeverege : Beverage
    {
        public PlainBeverege() {
            Description = "plain beverage";
        }

        public override double Cost() => 1.99f;
    }
}
