using People.Filtering.System.Interfaces;
using System.Collections.Generic;


public class LoggerService : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}