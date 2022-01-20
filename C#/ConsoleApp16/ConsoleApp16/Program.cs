using System;
using System.Collections;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack mystack = new Stack();
            mystack.Push("Hello");
            mystack.Push("null");
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            mystack.Push(4);
            mystack.Push(5);

            foreach(var item in mystack)
            {
                Console.WriteLine(item);
            }

        }
        
    }
}
