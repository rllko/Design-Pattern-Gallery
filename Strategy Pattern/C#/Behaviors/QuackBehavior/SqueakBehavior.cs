namespace StrategyPattern.Behaviors.QuackBehavior
{
    internal class SqueakBehavior : IQuackBehavior
    {
        void IQuackBehavior.Quack() => Console.WriteLine("SQUEEAEAAAAAK");
    }

}
