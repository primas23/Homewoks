using System;

namespace OddNumber
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            long result = 0L;

            for (var i = 0; i < numberOfRows; i++)
            {
                result = result ^ long.Parse(Console.ReadLine());
            }

            Console.WriteLine(result);
        }
    }
}