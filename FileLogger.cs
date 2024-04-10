using System;
using System.IO;

namespace DependencyInjectionExample
{
    public class FileLogger: ILogger
    {
        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter("LogFile.txt"))
            {
                writer.Write(message);
                writer.Close();
            }
        }
    }
}