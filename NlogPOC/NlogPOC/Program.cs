

using NLog;

class Program
{
    private static Logger logger = LogManager.GetCurrentClassLogger();
    static void Main(string[] args)
    {
        logger.Error("This is my error message");
        Console.WriteLine("this is my program");
    }
}

