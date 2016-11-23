using System;
using System.Collections.Generic;

namespace _09.Sequnce
{
    public class Stratup
    {
        public static void Main()
        {
            Console.WriteLine("Please enter N:");
            int n = int.Parse(Console.ReadLine());
            int p = 50;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);

            Console.WriteLine("N = {0}", n);
            Console.WriteLine("P = {0}", p);
            Console.Write("S =");

            var index = 0;
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.Write(" {0}", current);
                index++;

                if (current == p)
                {
                    Console.WriteLine();
                    return;
                }

                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current);
            }
        }
    }
}
