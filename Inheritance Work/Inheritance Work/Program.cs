using System;

namespace Inheritance_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //               here ı can either enter info or leave it
            //               if ı leave it default will be called
            Post post1 = new Post("Thanks for the birthday wishes", true, "Teoman");
            Console.WriteLine(post1.ToString());
            ImagePost imagepost1 = new ImagePost("I bought some new shoes!", "Teoman", "https://images.com/shoes", true);
            Console.WriteLine(imagepost1.ToString());
            VideoPost videopost1 = new VideoPost("Check out this video", "Teoman", "https://randomsomthing.com", 12, true);
            
            Console.WriteLine(videopost1.ToString());

            videopost1.Play();
            Console.WriteLine("press any key to stop");
            Console.ReadKey();
            videopost1.Stop();
            
        }
    }
}
