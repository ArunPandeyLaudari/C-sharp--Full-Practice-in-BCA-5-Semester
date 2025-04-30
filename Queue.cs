using System;
using System.Collections.Generic;

namespace Program
{
    class QueueExample
    {
        static void Main(string[] args)
        {
            Queue<string> a1 = new Queue<string>();

            a1.Enqueue("Example Item");
            Console.WriteLine("Item added to the queue: Example Item");
        }
    }
}