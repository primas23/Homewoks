using System;

namespace _10.Operations
{
    public class Startup
    {
        private static string result = string.Empty;

        public static void Main()
        {
            int n = 5;
            int m = 16;
           
            Operate(n, m, n.ToString());

            Console.WriteLine(result);
        }

        public static void Operate(int sofar, int m, string concat)
        {
            if (sofar >= m)
            {
                if (sofar == m)
                {
                    if (result == string.Empty)
                    {
                        result = concat;
                    }
                    else if (concat.Length < result.Length)
                    {
                        result = concat;                        
                    }
                }
                else
                {
                    return;
                }
            }

            int plusOne = sofar + 1;
            int plusTwo = sofar + 2;
            int multiplyByTwo = sofar * 2;

            Operate(plusOne, m, concat + "->" + plusOne);
            Operate(plusTwo, m, concat + "->" + plusTwo);
            Operate(multiplyByTwo, m, concat + "->" + multiplyByTwo);
        }
    }
}

