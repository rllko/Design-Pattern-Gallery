using StrategyPattern.Behaviors.FlyBehaviors;
using StrategyPattern.Behaviors.QuackBehavior;

namespace StrategyPattern
{
    internal class ModelDuck : Duck
    {
        public ModelDuck()
        {
            Flyebehavior = new FlyNoWay();
            QackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("model duck quack");
        }
    }
}
