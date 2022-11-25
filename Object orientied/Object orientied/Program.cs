using System;

namespace Object_orientied
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an object of my class
            // an instance of human
            //old way of doing that

            //Human teo = new Human();

            //access public variable from outside, and even change it

            //teo.firstName = "Teoman";
            //teo.lastName = "Öztürk";

            // call methods of the class

            //teo.IntroduceMyself();

            Human teo = new Human("Teoman", "Öztürk" , 20 , "Brown");

            teo.IntroduceMyself();
            
            //Human basicHuman = new Human();

            //basicHuman.IntroduceMyself();


            Human gizliTeo = new Human("Teo", "dordor", "Blue");

            gizliTeo.IntroduceMyself();

            Human dahaGizliTeo = new Human("Teo", "dordor");

            dahaGizliTeo.IntroduceMyself();

            Human enGizliTeo = new Human("Teo");

            enGizliTeo.IntroduceMyself();

        }
    }
}
