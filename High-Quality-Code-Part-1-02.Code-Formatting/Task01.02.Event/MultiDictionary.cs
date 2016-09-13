// <copyright file="MultiDictionary.cs" company="Primas">
//     Copyright (c) Primas. All rights reserved.
// </copyright>
// <author>Petar Petrov</author>
namespace Task01._02.Event
{
    using System.Collections;

    /// <summary>
    /// Created class for the building the be successful
    /// </summary>
    /// <typeparam name="T1">The type of the 1.</typeparam>
    /// <typeparam name="T2">The type of the 2.</typeparam>
    internal class MultiDictionary<T1, T2>
    {
        /// <summary>
        /// The v
        /// </summary>
        private bool v;

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiDictionary{T1, T2}"/> class.
        /// </summary>
        /// <param name="v">if set to <c>true</c> [v].</param>
        public MultiDictionary(bool v)
        {
            this.v = v;
        }

        /// <summary>
        /// Adds the specified to lower.
        /// </summary>
        /// <param name="toLower">To lower.</param>
        /// <param name="newEvent">The new event.</param>
        /// <exception cref="System.NotImplementedException">Not Implemented</exception>
        public void Add(string toLower, Event newEvent)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Removes the specified title.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <exception cref="System.NotImplementedException">Not Implemented</exception>
        public void Remove(string title)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the <see cref="IEnumerable"/> with the specified title.
        /// </summary>
        /// <value>
        /// The <see cref="IEnumerable"/>.
        /// </value>
        /// <param name="title">The title.</param>
        /// <returns>Not Implemented</returns>
        /// <exception cref="System.NotImplementedException">Not Implemented</exception>
        public IEnumerable this[string title]
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}