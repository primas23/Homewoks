// <copyright file="ExamResult.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace Exceptions_Homework
{
    using System;

    /// <summary>
    /// The Exam Result
    /// </summary>
    public class ExamResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExamResult"/> class.
        /// </summary>
        /// <param name="grade">The grade.</param>
        /// <param name="minGrade">The minimum grade.</param>
        /// <param name="maxGrade">The maximum grade.</param>
        /// <param name="comments">The comments.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The grade must not be less than 0
        /// or
        /// The minGrade must not be less than 0
        /// </exception>
        /// <exception cref="ArgumentException">The maxGrade is less than the minGrade</exception>
        /// <exception cref="ArgumentNullException">The comments are missing!</exception>
        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            if (grade < 0)
            {
                throw new ArgumentOutOfRangeException("The grade must not be less than 0");
            }

            if (minGrade < 0)
            {
                throw new ArgumentOutOfRangeException("The minGrade must not be less than 0");
            }

            if (maxGrade <= minGrade)
            {
                throw new ArgumentException("The maxGrade is less than the minGrade");
            }

            if (string.IsNullOrEmpty(comments))
            {
                throw new ArgumentNullException("The comments are missing!");
            }

            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        /// <summary>
        /// Gets the grade.
        /// </summary>
        /// <value>
        /// The grade.
        /// </value>
        public int Grade { get; private set; }

        /// <summary>
        /// Gets the minimum grade.
        /// </summary>
        /// <value>
        /// The minimum grade.
        /// </value>
        public int MinGrade { get; private set; }

        /// <summary>
        /// Gets the maximum grade.
        /// </summary>
        /// <value>
        /// The maximum grade.
        /// </value>
        public int MaxGrade { get; private set; }

        /// <summary>
        /// Gets the comments.
        /// </summary>
        /// <value>
        /// The comments.
        /// </value>
        public string Comments { get; private set; }
    }
}
