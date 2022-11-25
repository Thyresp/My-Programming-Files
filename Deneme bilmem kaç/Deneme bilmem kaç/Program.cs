using System;

namespace Deneme_bilmem_kaç
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = -3; i < 4; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("FİRST ONE İS DONE");
            int count = 4;
            while (count > -3)
            {
                count--;
                Console.WriteLine(count);
            }



            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("We Stop at 3");
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("We Skip 3");
                    continue;
                }
                Console.WriteLine(i);
            }

            int j = -10;

            while (j < 10)
            {

                if (j % 3 == 0)
                {
                    j++;
                    continue;
                }
                Console.WriteLine(j++);

            }

        }
    }
}
