// <copyright file="IWriter.cs" company="Primas">
//     Copyright (c) Primas. All rights reserved.
// </copyright>
// <author>Petar Petrov</author>
namespace Task01._01.BunnyFormat
{
    /// <summary>
    /// The Writer Interface
    /// </summary>
    public interface IWriter
    {
        /// <summary>
        /// Writes the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        void Write(string message);

        /// <summary>
        /// Writes the line.
        /// </summary>
        /// <param name="message">The message.</param>
        void WriteLine(string message);
    }
}