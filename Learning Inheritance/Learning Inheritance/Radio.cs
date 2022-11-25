using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Inheritance
{
    //child class
    internal class Radio : Electircal_Devices
    {
        //from what ı understand we dont delete this constructor because we are calling the radio not the electrical devices that it inherits
        public Radio(bool ısOn, string brand) : base(ısOn, brand)
        {

        }


        //method to listen ot the radio

        public void ListenRadio()
        {
            //first check if the
            if (IsOn)
            {
                //listen to radio
                Console.WriteLine("Listening to the Radio !");
            }
            else
            {
                //print error message
                Console.WriteLine("Radio is switched off, switch it on first");
            }
        }


    }
}
