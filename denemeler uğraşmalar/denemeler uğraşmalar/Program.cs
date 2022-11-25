using System;
using System.Timers;
namespace denemeler_uğraşmalar
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

                Timer aTimer = new Timer(1000);

                aTimer.Elapsed += OnTimedEvent;

                aTimer.AutoReset = true;

                aTimer.Enabled = true;

                Console.WriteLine("Press the Enter key to exit the program at any time... ");
                Console.ReadLine();
        }


        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
        }


}

}
