// <copyright file="Messages.cs" company="Primas">
//     Copyright (c) Primas. All rights reserved.
// </copyright>
// <author>Petar Petrov</author>
namespace Task01._02.Event
{
    using System.Text;

    /// <summary>
    /// The Messages class
    /// </summary>
    public static class Messages
    {
        /// <summary>
        /// The output
        /// </summary>
        private static readonly StringBuilder Output;

        /// <summary>
        /// Add the Event.
        /// </summary>
        public static void EventAdded()
        {
            Output.Append("Event added\n");
        }

        /// <summary>
        /// Delete the event
        /// </summary>
        /// <param name="x">The x.</param>
        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                Output.AppendFormat("{0} events deleted\n", x);
            }
        }

        /// <summary>
        /// No events found.
        /// </summary>
        public static void NoEventsFound()
        {
            Output.Append("No events found\n");
        }

        /// <summary>
        /// Prints the event.
        /// </summary>
        /// <param name="eventToPrint">The event to print.</param>
        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.Append(eventToPrint + "\n");
            }
        }
    }
}
