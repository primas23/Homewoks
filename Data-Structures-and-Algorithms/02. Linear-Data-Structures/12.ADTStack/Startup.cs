using System;

namespace _12.ADTStack
{
    public class Startup
    {
        public static void Main()
        {
            DynamicStack<int> stack = new DynamicStack<int>();

            stack.Push(1);
            stack.Push(2);
            Console.WriteLine(stack.Count);
            stack.Push(3);

            Console.WriteLine(stack.Top);
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Contains(1));
            Console.WriteLine(stack.Contains(2));
            Console.WriteLine(stack.Contains(3));
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            stack.Clear();
            Console.WriteLine(stack.Top);
        }
    }
}
