using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Inheritance
{
    internal class TV : Electircal_Devices
    {
        public TV(bool ısOn, string brand) : base(ısOn, brand)
        {

        }

        public void WatchTv()
        {
            //first check if the
            if (IsOn)
            {
                //listen to radio
                Console.WriteLine("Watching the Tv !");
            }
            else
            {
                //print error message
                Console.WriteLine("Tv is switched off, switch it on first!");
            }
        }

    }
}
