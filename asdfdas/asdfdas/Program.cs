using System;

namespace asdfdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3,4,5);
            /*box.Height = 4;
            box.Width = 5;
            //box.lenght = 3;
            box.SetLenght(3);*/
            box.DisplayInfo();
            Console.WriteLine($"box lenght is {box.GetLenght()}");
        }
    }
}
