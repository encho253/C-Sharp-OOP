namespace _07.Timer
{
    using System;
    using System.Timers;

    public static class TimerClass
    {       
        public static void Timer(int interval,Action<object,ElapsedEventArgs> method)
        {
            Timer timer = new Timer();
            timer.Elapsed += new ElapsedEventHandler(method);
            timer.Interval = interval;
            timer.Enabled = true;

            Console.WriteLine("Press \'q\' to quit the sample.");
            while (true) ;
        }       
    }
}