using System;

namespace Logger
{
    public class SimpleLogger
    {
        public static void Log(string message, string? caller)
        {
            Console.WriteLine($"{caller ?? string.Empty} Message: {message}");
        }
    }
}
