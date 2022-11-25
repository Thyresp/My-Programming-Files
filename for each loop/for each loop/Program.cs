using System;

namespace for_each_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
                Console.WriteLine("Element{0} = {1}",i,nums[i]);
            }
            int counter = 0;
            foreach (int i in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, i);
                counter++;
            }

            string[] bestFriends = new string[5] {"Ahmet","Hazel","Can","Deniz","Pınar"};

            foreach (string i in bestFriends)
            {
                Console.WriteLine($"Hello {i}");
            }

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int i in array)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }



        }
    }
}
