using DecoratorPattern;

//The Decorator Pattern attaches additional responsibilities to an object dynamically.
//Decorators provide a flexible alternative to subclassing for extending functionality.

Beverage beverage1 = new PlainBeverege();
Console.WriteLine(beverage1.GetDescription());

Beverage specialCocoa = new SpecialCocoaLatte();
Console.WriteLine(specialCocoa.GetDescription());
Console.WriteLine(specialCocoa.Cost());