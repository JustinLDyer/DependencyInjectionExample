namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass myConsoleLogger = new SampleClass(new ConsoleLogger());
            myConsoleLogger.LogMessage("This is a test of a console message");
            SampleClass myFileLogger = new SampleClass(new FileLogger());
            myFileLogger.LogMessage("This is a test of a file message");
        }
    }
}

