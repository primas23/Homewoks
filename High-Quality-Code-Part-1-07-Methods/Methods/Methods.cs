// <copyright file="Methods.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace Methods
{
    using System;

    /// <summary>
    /// The Methods class
    /// </summary>
    public class Methods
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(DigitsToString(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.AdditionalInformation = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.AdditionalInformation = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }

        /// <summary>
        /// Calculates the triangle area.
        /// </summary>
        /// <param name="a">The a side.</param>
        /// <param name="b">The b side.</param>
        /// <param name="c">The c side.</param>
        /// <returns>The calculated area</returns>
        /// <exception cref="ArgumentException">Sides should be positive.</exception>
        private static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }

        /// <summary>
        /// Converts digits to string.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>The string representation of the digit</returns>
        /// <exception cref="ArgumentException">The number you provided is not a digit (must be between 0-9)</exception>
        private static string DigitsToString(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            throw new ArgumentException("The number you provided is not a digit (must be between 0-9)");
        }

        /// <summary>
        /// Finds the max number.
        /// </summary>
        /// <param name="elements">The elements.</param>
        /// <returns>The biggest number</returns>
        /// <exception cref="ArgumentNullException">The array is null</exception>
        /// <exception cref="ArgumentException">There is no elements in the array</exception>
        private static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("The array is null");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException("There is no elements in the array");
            }

            int max = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Prints as number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="format">The format.</param>
        /// <exception cref="ArgumentNullException">
        /// You must supply the format parameter
        /// or
        /// You must supply the number parameter
        /// </exception>
        /// <exception cref="ArgumentException">The format is not supported</exception>
        private static void PrintAsNumber(object number, string format)
        {
            if (string.IsNullOrWhiteSpace(format))
            {
                throw new ArgumentNullException("You must supply the format parameter");
            }

            if (number == null)
            {
                throw new ArgumentNullException("You must supply the number parameter");
            }

            if (string.Equals(format, "f", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (string.Equals(format, "%", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (string.Equals(format, "r", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("{0,8}", number);
            }
            else
            {
                throw new ArgumentException("The format is not supported");
            }
        }

        /// <summary>
        /// Calculates the distance.
        /// </summary>
        /// <param name="x1">The x1.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="y2">The y2.</param>
        /// <param name="isHorizontal">if set to <c>true</c> [is horizontal].</param>
        /// <param name="isVertical">if set to <c>true</c> [is vertical].</param>
        /// <returns>The calculated distance</returns>
        private static double CalcDistance(double x1, double y1, double x2, double y2, out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = Math.Abs(y1 - y2) < 0.001;
            isVertical = Math.Abs(x1 - x2) < 0.001;

            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }
    }
}
