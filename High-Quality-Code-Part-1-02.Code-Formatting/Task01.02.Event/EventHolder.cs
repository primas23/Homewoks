// <copyright file="EventHolder.cs" company="Primas">
//     Copyright (c) Primas. All rights reserved.
// </copyright>
// <author>Petar Petrov</author>
namespace Task01._02.Event
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The event holder class
    /// </summary>
    public class EventHolder
    {
        /// <summary>
        /// The compare by title
        /// </summary>
        private MultiDictionary<string, Event> compareByTitle = new MultiDictionary<string, Event>(true);

        /// <summary>
        /// The compare by date
        /// </summary>
        private OrderedBag<Event> compareByDate = new OrderedBag<Event>();

        /// <summary>
        /// Adds the event.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="title">The title.</param>
        /// <param name="location">The location.</param>
        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);

            this.compareByTitle.Add(title.ToLower(), newEvent);
            this.compareByDate.Add(newEvent);

            Messages.EventAdded();
        }

        /// <summary>
        /// Deletes the events.
        /// </summary>
        /// <param name="titleToDelete">The title to delete.</param>
        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;

            foreach (var eventToRemove in this.compareByTitle[title])
            {
                removed++;
                this.compareByDate.Remove(eventToRemove);
            }

            this.compareByTitle.Remove(title);

            Messages.EventDeleted(removed);
        }

        /// <summary>
        /// Lists the events.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="count">The count.</param>
        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.VieweventsToShow = this.compareByDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);

            int showed = 0;

            IEnumerable<Event> eventsToShow = null;

            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);

                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}
