using StrategyPattern.Behaviors.FlyBehaviors;
using StrategyPattern.Behaviors.QuackBehavior;

namespace StrategyPattern
{
    internal class MallardDuck : Duck
    {

        public MallardDuck()
        {
            Flyebehavior = new FlyNoWay();
            QackBehavior = new MuteQuack();
        }

        public override void Swim()
        {
            Console.WriteLine("SWIIM SWIIM NIGGA");
        }

        public override void Display()
        {
            Console.WriteLine("MALlARD BRO!!!!!");
        }
    }
}
