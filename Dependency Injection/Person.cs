namespace Dependency_Injection
{
    public abstract class Person(string name)
    {
        public string Name { get; set; } = name;
    }

    public class PersonCtorInjection : Person
    {
        public PersonCtorInjection(string name, ILogger logger) : base(name)
        {
            logger.Log($"Person named {name} logged through ctor injection");
        }
    }

    public class PersonMethodInjection(string name) : Person(name)
    {
        public void DoComplexThings(ILogger logger)
        {
            // complex tasks
            logger.Log($"Person named {name} logged through method injection");
        }
    }

    public class PersonPropInjection(string name) : Person(name)
    {
        public required ILogger Logger { get; init; }

        public void DoComplexThings()
        {
            // complex tasks
            Logger.Log($"Person named {this.Name} logged through prop injection");
        }
    }
}
