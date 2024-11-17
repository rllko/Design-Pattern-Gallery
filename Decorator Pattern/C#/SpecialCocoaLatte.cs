﻿using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class SpecialCocoaLatte : Beverage
    {
        private readonly Beverage beverage;
        public SpecialCocoaLatte() {
            beverage = new MilkDecorator(new CocoaDecorator(new PlainBeverege()));
        }
        public override double Cost()
        {
            return beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription();
        }
    }

}

