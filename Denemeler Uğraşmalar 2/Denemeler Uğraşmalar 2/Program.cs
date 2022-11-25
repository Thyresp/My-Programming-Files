using System;
using System.Threading;

namespace Denemeler_Uğraşmalar_2
{
    internal class Program
    {
        private static int counter;
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(TimerCallBack, null, 0, 1000);
            Console.Read();
        }

        //look at callbacks sometime
        private static void TimerCallBack(Object o)
        {
            Console.WriteLine(++counter);
        }
    }
}
