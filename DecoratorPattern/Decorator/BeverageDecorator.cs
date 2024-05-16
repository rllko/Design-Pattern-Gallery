using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    internal abstract class BeverageDecorator(Beverage beverage) : Beverage
    {
        public readonly Beverage Beverage = beverage;
        public override abstract string GetDescription();
    }
}
