using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdfdas
{
    internal class Box
    {
        private int height;
        //public int width;
        private int lenght;
        private int volume;

        //properties

        public int Width { get; set; }

        public int Volume
        {
            get 
            {
                return this.lenght*this.Width*this.height; 
            }
        }

        


        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
                
            }

        }

        public Box(int height, int lenght, int width)
        {
            this.height = height;
            this.lenght = lenght;
            Width = width;
        }





        //setter
        public void SetLenght(int lenght)
        {   if(lenght < 0)
            {
                throw new Exception("Lenght Should Be Higher Than 0");
            }
            this.lenght = lenght;
        }
        //getter
        public int GetVolume()
        {
            return this.lenght*this.Width*this.height;
        }
        public int GetLenght()
        { 
            return this.lenght; 
        }






        public void DisplayInfo()
        {
            Console.WriteLine($"height is {height} width is {Width} length is {lenght} and volume is {Volume} ");
        }
    }

}
