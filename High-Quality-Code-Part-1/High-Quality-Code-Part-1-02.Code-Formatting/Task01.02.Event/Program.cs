// <copyright file="Program.cs" company="Primas">
//     Copyright (c) Primas. All rights reserved.
// </copyright>
// <author>Petar Petrov</author>
namespace Task01._02.Event
{
    using System;
    using System.Text;

    /// <summary>
    /// The Main class of the application
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The output.
        /// </summary>
        private static StringBuilder output = new StringBuilder();

        /// <summary>
        /// The events.
        /// </summary>
        private static EventHolder events = new EventHolder();

        /// <summary>
        /// The application entry point.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            while (ExecuteNextCommand())
            {
            }

            Console.WriteLine(output);
        }

        /// <summary>
        /// Executes the next command.
        /// </summary>
        /// <returns>If the command was executed</returns>
        private static bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();
            if (command[0] == 'A')
            {
                AddEvent(command);
                return true;
            }

            if (command[0] == 'D')
            {
                DeleteEvents(command);
                return true;
            }

            if (command[0] == 'L')
            {
                ListEvents(command);
                return true;
            }

            if (command[0] == 'E')
            {
                return false;
            }

            return false;
        }

        /// <summary>
        /// List of the events.
        /// </summary>
        /// <param name="command">The command.</param>
        private static void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');
            DateTime date = GetDate(command, "ListEvents");

            string countString = command.Substring(pipeIndex + 1);

            int count = int.Parse(countString);
            events.ListEvents(date, count);
        }

        /// <summary>
        /// Deletes the events.
        /// </summary>
        /// <param name="command">The command.</param>
        private static void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1);
            events.DeleteEvents(title);
        }

        /// <summary>
        /// Adds the event.
        /// </summary>
        /// <param name="command">The command.</param>
        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;

            GetParameters(command, "AddEvent", out date, out title, out location);

            events.AddEvent(date, title, location);
        }

        /// <summary>
        /// Gets the parameters.
        /// </summary>
        /// <param name="commandForExecution">The command for execution.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="dateAndTime">The date and time.</param>
        /// <param name="eventTitle">The event title.</param>
        /// <param name="eventLocation">The event location.</param>
        private static void GetParameters(
            string commandForExecution,
            string commandType,
            out DateTime dateAndTime,
            out string eventTitle,
            out string eventLocation)
        {
            dateAndTime = GetDate(commandForExecution, commandType);
            int firstPipeIndex = commandForExecution.IndexOf('|');
            int lastPipeIndex = commandForExecution.LastIndexOf('|');
            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
                eventLocation = string.Empty;
            }
            else
            {
                eventTitle = commandForExecution
                    .Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1)
                    .Trim();

                eventLocation = commandForExecution
                    .Substring(lastPipeIndex + 1)
                    .Trim();
            }
        }

        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns>The date of the command</returns>
        private static DateTime GetDate(string command, string commandType)
        {
            DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));
            return date;
        }
    }
}