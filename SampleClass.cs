using System;

namespace DependencyInjectionExample 
{
    public class SampleClass
    {
        private readonly ILogger logger;
        public SampleClass(ILogger logger)
        {
            this.logger = logger;
        }

        public void LogMessage(string message)
        {
            this.logger.Log(message);
        }
    }
}