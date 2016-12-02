using System;

namespace _01.SimulatesExecutionOfNLoops
{
    public class Startup
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int[] arr = new int[number];

            LoopMe(0, arr);
        }

        public static void LoopMe(int index, int[] arr)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(String.Join("", arr));
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {                
                arr[index] = i + 1;
                LoopMe(index + 1, arr);
            }            
        }
    }
}
