using System;
using System.Collections.Generic;

namespace ChallangeNumberSomething
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> ();

            for(int i = 100; i <= 170; i++)
            {
                if (i % 2 == 0)
                {
                    numbers.Add (i);
                    
                }
            }

            
        }
    }
}
