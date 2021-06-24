using System;

namespace Logger
{
    public class SimpleLogger
    {
        public static void Log(string message)
        {
            Console.WriteLine($"Message: {message}");
        }
    }
}
