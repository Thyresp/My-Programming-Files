using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Inheritance
{
    //parent class - base class
    internal class Electircal_Devices
    {
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public Electircal_Devices(bool ısOn, string brand)
        {
            IsOn = ısOn;
            Brand = brand;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }


    }
}
