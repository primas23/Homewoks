using System;

namespace OddNumber
{
    public class Startup
    {
        public static void Main()
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            long[] arr = new long[numberOfRows];

            for (int i = 0; i < numberOfRows; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            int counter = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    long a = arr[i];
                    long b = arr[j];

                    if (arr[i] == arr[j])
                    {
                        counter++;
                        i = j;
                    }
                    else
                    {
                        break;
                    }
                }

                if ((counter & 1) != 0)
                {
                    Console.WriteLine(arr[i]);
                    break;
                }

                counter = 1;
            }
        }
    }
}
