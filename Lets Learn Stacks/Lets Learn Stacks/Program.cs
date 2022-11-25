using System;
using System.Collections.Generic;

namespace Lets_Learn_Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //defining a new  stack
            Stack<int> myStack = new Stack<int>();
            //add elements to the stack using Push()
            //adding elements to the stack and printing the value on top of the stack using peek


            myStack.Push(1);
            Console.WriteLine("Top value in the stack is : {0}", myStack.Peek());
            myStack.Push(2);
            Console.WriteLine("Top value in the stack is : {0}", myStack.Peek());
            myStack.Push(3);
            //remove items from a stack
            int myStackItem = myStack.Pop();
            Console.WriteLine("Popped item is : {0}", myStackItem);
            Console.WriteLine("Top value in the stack is : {0}", myStack.Peek());

            while(myStack.Count > 0)
            {
                myStack.Pop();
            }

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };

            Stack<int> stack = new Stack<int>();

            foreach(int number in numbers)
            {
                stack.Push(number);
            }

            while(stack.Count > 0)
            {
                int poppedStack = stack.Pop();
                Console.WriteLine(poppedStack);
            }

        }
    }
}
