using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Majorant
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

            int[] array = sequence.ToArray();
            int? magoranta = null;

            IEnumerable<IGrouping<int, int>> groups = array.GroupBy(num => num);

            foreach (IGrouping<int,int> group in groups)
            {
                if (group.Count() >= ((array.Length / 2) + 1))
                {
                    magoranta = group.Key;
                }
            }

            Console.WriteLine(magoranta != null ? magoranta.ToString() : "NO magoranta");
        }
    }
}
