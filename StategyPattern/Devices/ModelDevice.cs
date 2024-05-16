namespace StrategyPattern.Devices;

internal abstract class ModelDevice
{
    IQuackBehavior QuackBehavior { get; set; }

    public void performanceQuack()
    {
        QuackBehavior?.Quack();
    }
}
