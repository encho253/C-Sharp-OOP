using System;
using System.Timers;

namespace _07.Timer
{
    public class StartProgram
    {
        public static void Main()
        {
            TimerClass.Timer(5000,OnTimedEvent);
        }

        // Specify what you want to happen when the Elapsed event is raised.
        public static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Hello World!");
        }
    }
}