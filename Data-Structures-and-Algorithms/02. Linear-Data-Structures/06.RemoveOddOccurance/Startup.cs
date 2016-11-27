using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.RemoveOddOccurance
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
            
            IEnumerable<IGrouping<int, int>> groups = sequence.GroupBy(num => num);

            foreach (IGrouping<int, int> group in groups)
            {
                if (group.Count() % 2 != 0)
                {
                    while (sequence.Contains(group.Key))
                    {
                        sequence.Remove(group.Key);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
