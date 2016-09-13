// <copyright file="OrderedBag.cs" company="Primas">
//     Copyright (c) Primas. All rights reserved.
// </copyright>
// <author>Petar Petrov</author>
namespace Task01._02.Event
{
    /// <summary>
    /// Created class for the building the be successful
    /// </summary>
    /// <typeparam name="T">The generic parameter</typeparam>
    internal class OrderedBag<T>
    {
        /// <summary>
        /// Gets or sets the view events to show.
        /// </summary>
        /// <value>
        /// The view events to show.
        /// </value>
        public static object VieweventsToShow { get; set; }

        /// <summary>
        /// Adds the specified new event.
        /// </summary>
        /// <param name="newEvent">The new event.</param>
        /// <exception cref="System.NotImplementedException">Not Implemented</exception>
        public void Add(Event newEvent)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Removes the specified event to remove.
        /// </summary>
        /// <param name="eventToRemove">The event to remove.</param>
        /// <exception cref="System.NotImplementedException">Not Implemented</exception>
        public void Remove(object eventToRemove)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Ranges from.
        /// </summary>
        /// <param name="event">The event.</param>
        /// <param name="b">if set to <c>true</c> [b].</param>
        /// <returns>Not Implemented</returns>
        /// <exception cref="System.NotImplementedException">Not Implemented</exception>
        public object RangeFrom(Event @event, bool b)
        {
            throw new System.NotImplementedException();
        }
    }
}