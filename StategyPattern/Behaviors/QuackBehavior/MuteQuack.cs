using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Behaviors.QuackBehavior
{
    internal class MuteQuack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("THE SSOOOUND, OF SILEEEEEENCE");
        }
    }
}
