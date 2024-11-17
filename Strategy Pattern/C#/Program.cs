using StrategyPattern;
using StrategyPattern.Behaviors.FlyBehaviors;

/**
The Strategy Pattern defines a family of algorithms, encapsulates each one,
and makes them interchangeable.
Strategy lets the algorithm vary independently from clients that use it.
*/

Duck mallard = new MallardDuck();

mallard.PerformFly();
mallard.PerformQuack();
mallard.Display();

mallard.Flyebehavior = new FlyNoWay();

Duck modelDuck = new ModelDuck
{
    Flyebehavior = new FlyRocketPowered()
};
modelDuck.PerformFly();