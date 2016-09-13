// <copyright file="StringExtensions.cs" company="Primas">
//     Copyright (c) Primas. All rights reserved.
// </copyright>
// <author>Petar Petrov</author>
namespace Task01._01.BunnyFormat
{
    using System.Text;

    /// <summary>
    /// String extensions
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Splits to separate words by uppercase letter.
        /// </summary>
        /// <param name="sequence">The sequence.</param>
        /// <returns>The split words</returns>
        public static string SplitToSeparateWordsByUppercaseLetter(this string sequence)
        {
            var probableStringMargin = 10;
            var probableStringSize = sequence.Length + probableStringMargin;
            var builder = new StringBuilder(probableStringSize);

            var singleWhitespace = ' ';
            foreach (var letter in sequence)
            {
                if (char.IsUpper(letter))
                {
                    builder.Append(singleWhitespace);
                }

                builder.Append(letter);
            }

            return builder.ToString().Trim();
        }
    }
}