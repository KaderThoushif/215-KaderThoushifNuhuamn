using System;
using System.Collections;


namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("Hello");
            q.Enqueue(null);
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            foreach (var item in q)
            {
                
                Console.WriteLine(item);
            }

        }
    }
}
