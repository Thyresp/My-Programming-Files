using System;

namespace Learning_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTv = new TV(false, "Samsung");
            //method from the parent class
            myTv.SwitchOn();
            //method from the child class
            myTv.WatchTv();
        }
    }
}
