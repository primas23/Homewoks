using System;
using System.Collections.Generic;

namespace _01.SequencePositiveIntegerNumbers
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Enter positive numbers. To break, enter blank line: ");

            IList<int> sequence = new List<int>();

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
                sequence.Add(number);
            }

            int sum = 0;
            foreach (var item in sequence)
            {
                sum += item;
            }

            Console.WriteLine("Sum: {0}, average: {1}", sum, (double)sum / sequence.Count);
        }
    }
}
