using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Behaviors.FlyBehaviors
{
    internal class FlyNoWay : FlyBehavior
    {
        void FlyBehavior.fly()
        {
            Console.WriteLine("flying but not anywhere, dw");
        }
    }
}
