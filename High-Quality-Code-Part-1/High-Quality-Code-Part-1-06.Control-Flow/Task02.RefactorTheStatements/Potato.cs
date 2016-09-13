// <copyright file="Potato.cs" company="Primas">
//     Copyright (c) Primas. All rights reserved.
// </copyright>
// <author>Petar Petrov</author>
namespace Task02.RefactorTheStatements
{
    /// <summary>
    /// Created class for compiling
    /// </summary>
    internal class Potato
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance has not been peeled.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance has not been peeled; otherwise, <c>false</c>.
        /// </value>
        public bool HasNotBeenPeeled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is rotten.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is rotten; otherwise, <c>false</c>.
        /// </value>
        public bool IsRotten { get; set; }
    }
}