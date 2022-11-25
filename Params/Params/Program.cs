using System;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";

            ParamsMethod2(price,pi,at,book);
            ParamsMethod2("Hello", 5.3, '$');
            ParamsMethod("Basicly", "params", "lets", "us", "write", "as", "many", "arguments", "as", "possible");
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for(int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {

            foreach(object o in stuff)
            {
                Console.Write(o + " ");
            } 
        }
    }
}
