using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestSubsequenceEqualNumbers
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

            Console.WriteLine("The longest sequence is the number {0} wich is repeated {1} times!", GetLongestSequence(sequence).Key, GetLongestSequence(sequence).Value);
        }

        /// <summary>
        /// Gets the longest sequence. If no repeat returns the first number
        /// </summary>
        /// <param name="sequece">The sequece.</param>
        /// <returns>Key value pair with key equals to the number and the value equals to the times the number is repeated</returns>
        /// <exception cref="System.ArgumentNullException">You must supply sequence!</exception>
        public static KeyValuePair<int, int> GetLongestSequence(IList<int> sequece)
        {
            if (sequece == null)
            {
                throw new ArgumentNullException("You must supply sequence!");
            }

            int number = 0;
            int numberCount = 0;

            foreach (int numberInSeq in sequece.Distinct())
            {
                int numberInSeqCount = sequece.Count(i => i == numberInSeq);

                if (numberCount < numberInSeqCount)
                {
                    number = numberInSeq;
                    numberCount = numberInSeqCount;
                }
            }

            return new KeyValuePair<int, int>(number, numberCount);
        }
    }
}
