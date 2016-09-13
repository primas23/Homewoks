namespace Task_1.class_123
{
    using System;

    /// <summary>
    /// The main console application class
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// The maximum count
        /// </summary>
        private const int MaxCount = 6;
        
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            WriteOnConsole currentConsole = new WriteOnConsole();

            currentConsole.ConsoleWriteLine(true);
        }

        /// <summary>
        /// Write to console class
        /// </summary>
        public class WriteOnConsole
        {
            /// <summary>
            /// Wtrites to the console`s line
            /// </summary>
            /// <param name="boolVariable">if set to <c>true</c> it write True on the console, else writes False.</param>
            public void ConsoleWriteLine(bool boolVariable)
            {
                string boolVariableAsString = boolVariable.ToString();
                Console.WriteLine(boolVariableAsString);
            }
        }
    }
}