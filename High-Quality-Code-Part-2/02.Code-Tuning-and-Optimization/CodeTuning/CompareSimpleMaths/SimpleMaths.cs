namespace CompareSimpleMaths
{
    public class SimpleMaths
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            MathPerformance.Performance(Operation.Addition);
            MathPerformance.Performance(Operation.Division);
            MathPerformance.Performance(Operation.Multiplication);
            MathPerformance.Performance(Operation.Subtracion);
        }
    }
}
