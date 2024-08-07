using Dependency_Injection;

var logger = new Logger();

var PersonCtorInjection = new PersonCtorInjection("John Doe", logger);

var PersonMethodInjection = new PersonMethodInjection("Jane Dow");
PersonMethodInjection.DoComplexThings(logger);

var PersonPropInjection = new PersonPropInjection("Jack Smith")
{
    Logger = logger
};
PersonPropInjection.DoComplexThings();