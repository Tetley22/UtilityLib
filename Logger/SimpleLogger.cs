using System;

namespace Logger
{
    public class SimpleLogger
    {
        static int counter = 0;
        
        public static void Log(string message, string? caller)
        {
            Console.WriteLine($"[{counter}:{caller}] Message: {message}");
            ++counter;
        }
    }
}
