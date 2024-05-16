using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    internal class CocoaDecorator(Beverage beverage) : BeverageDecorator(beverage) 
    {
        public override double Cost() => Beverage.Cost() + 0.50;

        public override string GetDescription() => $"{Beverage.GetDescription()},Cocoa";
    }
}
