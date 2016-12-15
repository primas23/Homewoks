using System;

namespace OddNumber
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long res = 0L;

            for (var i = 0; i < n; i++)
            {
                res = res ^ long.Parse(Console.ReadLine());
            }

            Console.WriteLine(res);
        }
    }
}