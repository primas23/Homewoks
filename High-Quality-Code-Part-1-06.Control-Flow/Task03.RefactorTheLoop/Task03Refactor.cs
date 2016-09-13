// <copyright file="Task03Refactor.cs" company="Primas">
//     Copyright (c) Primas. All rights reserved.
// </copyright>
// <author>Petar Petrov</author>
namespace Task03.RefactorTheLoop
{
    using System;

    /// <summary>
    /// A class created for compiling the code
    /// </summary>
    public class Task03Refactor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Task03Refactor"/> class.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="expectedValue">The expected value.</param>
        public Task03Refactor(string[] array, string expectedValue)
        {
            for (int i = 0; i < 100; i++)
            {
                string currentValue = array[i];

                Console.WriteLine(currentValue);

                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                    }
                }
            }
        }
    }
}
