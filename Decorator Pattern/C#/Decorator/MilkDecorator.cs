using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    internal class MilkDecorator(Beverage beverage) : BeverageDecorator(beverage)
    {
        public override double Cost() =>
            Ssize switch
            {
                Size.TALL => Beverage.Cost() + 0.20f,
                Size.VENTI => Beverage.Cost() + 0.15f,
                Size.GRANDE => Beverage.Cost() + 0.10f,
                _ => throw new ArgumentException(message: "invalid Size", paramName: nameof(Size))
            };

        public override string GetDescription() => $"{Beverage.GetDescription()}, Milk";

    };
}
