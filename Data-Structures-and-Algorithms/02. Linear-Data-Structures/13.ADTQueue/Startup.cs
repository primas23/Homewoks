using System;

namespace _13.ADTQueue
{
    public class Startup
    {
        public static void Main()
        {
            DynamicQueue<int> queue = new DynamicQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Count);
            queue.Clear();
            Console.WriteLine(queue.Count);
        }
    }
}
