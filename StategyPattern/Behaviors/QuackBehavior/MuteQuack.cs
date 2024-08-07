namespace StrategyPattern.Behaviors.QuackBehavior
{
    internal class MuteQuack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("THE SSOOOUND, OF SILEEEEEENCE");
        }
    }
}
