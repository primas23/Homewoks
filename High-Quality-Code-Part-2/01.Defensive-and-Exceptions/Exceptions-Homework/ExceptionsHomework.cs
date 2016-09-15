// <copyright file="ExceptionsHomework.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The Exceptions Homework
    /// </summary>
    public class ExceptionsHomework
    {
        /// <summary>
        /// Makes a subsequence of array
        /// </summary>
        /// <typeparam name="T">Any type</typeparam>
        /// <param name="arr">The array.</param>
        /// <param name="startIndex">The start index.</param>
        /// <param name="count">The count.</param>
        /// <returns>An array of extracted elements</returns>
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        /// <summary>
        /// Extracts the ending.
        /// </summary>
        /// <param name="str">The string from which to extract.</param>
        /// <param name="count">The count of the string it should return.</param>
        /// <returns>Extracted string</returns>
        public static string ExtractEnding(string str, int count)
        {
            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("The string you supplyed is shorter then the string you wish to extract!");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        /// <summary>
        /// Checks if the number is prime.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <exception cref="Exception">The number is not prime!</exception>
        /// <returns>Returns if the number is prime</returns>
        public static bool CheckIfPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));

            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));
            Console.WriteLine(ExtractEnding("Hi", 100));
            
            if (CheckIfPrime(23))
            {
                Console.WriteLine("23 is prime.");
            }
            
            if (CheckIfPrime(33))
            {
                Console.WriteLine("33 is prime.");
            }
            
            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };

            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();

            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}
