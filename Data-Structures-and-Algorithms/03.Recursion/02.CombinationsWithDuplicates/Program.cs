using System;

namespace _02.CombinationsWithDuplicates
{
    public class Program
    {
        const int N = 3;
        const int K = 2;

        static int[] _arr = new int[K];

        public static void Main()
        {
            GenerateCombinationsNoRepetitions(0, 0);
        }

        static void GenerateCombinationsNoRepetitions(int index, int start)
        {
            if (index >= K)
            {
                PrintVariations();
            }
            else
            {
                for (int i = start; i < N; i++)
                {
                    _arr[index] = i;
                    GenerateCombinationsNoRepetitions(index + 1, i);
                }
            }
        }

        static void PrintVariations()
        {
            Console.Write("( ");
            foreach (int t in _arr)
            {
                Console.Write(t + 1 + " ");
            }
            Console.WriteLine(')');
        }
    }
}
