using System;

namespace Logger
{
    public class SimpleLogger
    {
        static int counter = 0;
        
        public static void Log(string message)
        {
            Console.WriteLine($"{counter} Message: {message}");
            ++counter;
        }
    }
}
