using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2
{
    internal class Class1
    {
        private int height;
        private int lenght;
        //private int deneme;
        public int FrontSurface 
        {

            get
            {
                return this.height*this.lenght;
            }

        }

        //memeber constructor
        public Class1(int height,int lenght)
        {
            this.height = height;
            this.lenght = lenght;
        }
        
        // member - finalizer - deconstructor
        ~Class1()
        {
            Console.WriteLine("Deconstruction of Class1 Object");
        }





        /*public int Deneme
        {
            get
            {
                return deneme;
            }

            set
            {
                deneme = value;
            }
        }*/




        public void DisplayInfo()
        {
            Console.WriteLine(FrontSurface);
        }
    }
}
