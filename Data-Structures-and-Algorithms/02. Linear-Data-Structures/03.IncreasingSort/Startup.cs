using System;
using System.Collections.Generic;

namespace _03.IncreasingSort
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Enter numbers. To break, enter blank line: ");

            List<int> list = new List<int>();

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
                list.Add(number);
            }

            list.Sort();
            list.ForEach(Console.WriteLine);
        }
    }
}
