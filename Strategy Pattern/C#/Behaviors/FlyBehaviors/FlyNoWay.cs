namespace StrategyPattern.Behaviors.FlyBehaviors
{
    internal class FlyNoWay : FlyBehavior
    {
        void FlyBehavior.fly()
        {
            Console.WriteLine("flying but not anywhere, dw");
        }
    }
}
