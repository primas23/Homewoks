namespace CompareAdvancedMaths
{
    public class AdvancedMaths
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            MathPerformance.Performance(Operation.Square);
            MathPerformance.Performance(Operation.Logarithm);
            MathPerformance.Performance(Operation.Sinus);
        }
    }
}
