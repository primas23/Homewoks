// <copyright file="Student.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace Methods
{
    using System;
    using System.Globalization;

    /// <summary>
    /// The Students class
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the other information.
        /// </summary>
        /// <value>
        /// The Additional information.
        /// </value>
        public string AdditionalInformation { get; set; }

        /// <summary>
        /// Determines whether [is older than] [the specified other].
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns>
        ///   <c>true</c> if [is older than] [the specified other]; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// The first person date format is not supported
        /// or
        /// The second person date format is not supported
        /// </exception>
        /// <exception cref="ArithmeticException">The parse mas not successful</exception>
        public bool IsOlderThan(Student other)
        {
            string[] formats =
                {
                    "M/d/yyyy h:mm:ss tt",
                    "M/d/yyyy h:mm tt",
                    "MM/dd/yyyy hh:mm:ss",
                    "M/d/yyyy h:mm:ss",
                    "M/d/yyyy hh:mm tt",
                    "M/d/yyyy hh tt",
                    "M/d/yyyy h:mm",
                    "M/d/yyyy h:mm",
                    "MM/dd/yyyy hh:mm",
                    "M/dd/yyyy hh:mm"
                };

            string firsPersonData = this.AdditionalInformation.Substring(this.AdditionalInformation.Length - 10);
            string secondPersonData = other.AdditionalInformation.Substring(other.AdditionalInformation.Length - 10);

            DateTime firstDate = DateTime.MinValue;
            DateTime secondDate = DateTime.MinValue;

            bool isFirstParsed = false;
            bool isSecondParsed = false;

            foreach (string format in formats)
            {
                isFirstParsed = DateTime.TryParseExact(firsPersonData, format, new CultureInfo("en-US"), DateTimeStyles.None, out firstDate);
            }

            foreach (string format in formats)
            {
                isSecondParsed = DateTime.TryParseExact(secondPersonData, format, new CultureInfo("en-US"), DateTimeStyles.None, out secondDate);
            }

            if (isFirstParsed)
            {
                throw new ArgumentException("The first person date format is not supported");
            }

            if (isSecondParsed)
            {
                throw new ArgumentException("The second person date format is not supported");
            }

            if (firstDate == DateTime.MinValue || secondDate == DateTime.MinValue)
            {
                throw new ArithmeticException("The parse mas not successful");
            }

            return firstDate > secondDate;
        }
    }
}
