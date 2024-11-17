namespace Dependency_Injection;

public class Logger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}