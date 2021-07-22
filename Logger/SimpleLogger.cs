using System;

namespace Logger
{
    public class SimpleLogger
    {
        static int counter = 1;
        
        public static void Log(string message, string? caller, string emoji = "")
        {
            Console.WriteLine($"{emoji} [{counter}:{caller}] {message}");
            ++counter;
        }

        public static void LogInfo(string message, string? caller)
        {
            Log(message, caller, "😊");
        }

        public static void LogWarning(string message, string? caller)
        {
            Log(message, caller, "😢");
        }

        public static void LogError(string message, string? caller)
        {
            Log(message, caller, "😆");
        }
    }
}
