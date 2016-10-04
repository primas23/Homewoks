namespace CompareAdvancedMaths
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// The Math class
    /// </summary>
    public static class MathPerformance
    {
        private const double DOUBLE_VALUE = 50;
        private const int NUMBER_OF_CALCULATIONS = 1000000;
        private static Stopwatch stopWatch = new Stopwatch();

        /// <summary>
        /// Measures the Performances of the specified operation.
        /// </summary>
        /// <param name="operation">The operation.</param>
        /// <exception cref="InvalidOperationException"></exception>
        public static void Performance(Operation operation)
        {
            double resultDouble = 1;
            stopWatch.Restart();
            for (int i = 0; i < NUMBER_OF_CALCULATIONS; i++)
            {
                switch (operation)
                {
                    case Operation.Square:
                        resultDouble = Math.Sqrt(DOUBLE_VALUE);
                        break;
                    case Operation.Logarithm:
                        resultDouble = Math.Log(DOUBLE_VALUE);
                        break;
                    case Operation.Sinus:
                        resultDouble = Math.Sin(DOUBLE_VALUE);
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }

            var stopWatchResult = stopWatch.Elapsed;
            stopWatch.Stop();
            stopWatch.Reset();

            Console.WriteLine("The {0} for type double took {1}", operation, stopWatchResult);

            var floatToDoubleDelay = CastPerformance.FloatToDouble();
            Console.WriteLine("The {0} for type float took {1}", operation, stopWatchResult + floatToDoubleDelay);

            var decimalToDoubleDelay = CastPerformance.DecimalToDouble();
            Console.WriteLine("The {0} for type float took {1}", operation, stopWatchResult + decimalToDoubleDelay);
        }
    }
}