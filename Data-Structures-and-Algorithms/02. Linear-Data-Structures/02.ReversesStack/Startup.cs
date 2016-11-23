using System;
using System.Collections.Generic;

namespace _02.ReversesStack
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Enter positive numbers. To break, enter blank line: ");

            Stack<int> stack = new Stack<int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == string.Empty)
                {
                    break;
                }

                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentNullException("The input must not be null!");
                }

                int number = int.Parse(input);
                stack.Push(number);
            }

            while (stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
