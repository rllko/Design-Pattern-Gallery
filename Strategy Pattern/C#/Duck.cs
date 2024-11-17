using StrategyPattern.Behaviors.FlyBehaviors;
using StrategyPattern.Behaviors.QuackBehavior;

namespace StrategyPattern
{
    internal abstract class Duck
    {
        public FlyBehavior? Flyebehavior { get; set; }
        public IQuackBehavior? QackBehavior { get; set; }
        public abstract void Display();

        void fly()
        {

        }

        public virtual void Swim()
        {
            Console.WriteLine("Swimming lil bro ");
        }

        public void PerformFly()
        {
            Flyebehavior?.fly();
        }

        public void PerformQuack()
        {
            QackBehavior?.Quack();
        }
    }
}

