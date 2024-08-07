namespace StrategyPattern.Behaviors.FlyBehaviors
{
    internal class FlyWithWings : FlyBehavior
    {
        void FlyBehavior.fly()
        {
            Console.WriteLine("FLYING WITH WINGS OMG");
        }
    }
}
