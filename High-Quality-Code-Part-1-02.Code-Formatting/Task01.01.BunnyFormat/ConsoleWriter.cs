// <copyright file="ConsoleWriter.cs" company="Primas">
//     Copyright (c) Primas. All rights reserved.
// </copyright>
// <author>Petar Petrov</author>
namespace Task01._01.BunnyFormat
{
    using System;

    /// <summary>
    /// Console writer implementation of the IWriter interface
    /// </summary>
    /// <seealso cref="IWriter" />
    public class ConsoleWriter : IWriter
    {
        /// <summary>
        /// Writes the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Write(string message)
        {
            Console.Write(message);
        }

        /// <summary>
        /// Writes the line.
        /// </summary>
        /// <param name="message">The message.</param>
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}