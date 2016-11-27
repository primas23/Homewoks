using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemovesNegative
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Enter numbers. To break, enter blank line: ");

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

            List<int> sequenceWithoutNegatives = sequence
                .Where(i => i > 0)
                .ToList();

            sequenceWithoutNegatives.ForEach(Console.WriteLine);
        }
    }
}
