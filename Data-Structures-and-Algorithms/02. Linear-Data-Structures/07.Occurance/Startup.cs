using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Occurance
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

            Dictionary<int, int> occurances = GetOccurances(array);
            
            foreach (KeyValuePair<int, int> pair in occurances.OrderBy(o => o.Key))
            {
                Console.WriteLine(pair.Key + "->" + pair.Value);
            }
        }

        /// <summary>
        /// Gets the occurances.
        /// </summary>
        /// <param name="sequece">The sequece.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">You must supply sequence!</exception>
        public static Dictionary<int, int> GetOccurances(int[] sequece)
        {
            if (sequece == null)
            {
                throw new ArgumentNullException("You must supply sequence!");
            }

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach (int numberInSeq in sequece.Distinct())
            {
                int numberInSeqCount = sequece.Count(i => i == numberInSeq);

                dictionary.Add(numberInSeq, numberInSeqCount);
            }

            return dictionary;
        }
    }
}
