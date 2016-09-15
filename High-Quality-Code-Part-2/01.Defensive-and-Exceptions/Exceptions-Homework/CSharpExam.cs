// <copyright file="CSharpExam.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace Exceptions_Homework
{
    using System;

    /// <summary>
    /// The C# exam class
    /// </summary>
    /// <seealso cref="Exceptions_Homework.Exam" />
    public class CSharpExam : Exam
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSharpExam"/> class.
        /// </summary>
        /// <param name="score">The score.</param>
        /// <exception cref="ArgumentOutOfRangeException">The score must be larger then 0!</exception>
        public CSharpExam(int score)
        {
            if (score < 0)
            {
                throw new ArgumentOutOfRangeException("The score must be bigger then 0!");
            }

            this.Score = score;
        }

        /// <summary>
        /// Gets the score.
        /// </summary>
        /// <value>
        /// The score.
        /// </value>
        public int Score { get; private set; }

        /// <summary>
        /// Checks this Exam results.
        /// </summary>
        /// <returns>
        /// The Exam result
        /// </returns>
        /// <exception cref="InvalidOperationException">The score is must be bigger than 0 and less then 100</exception>
        public override ExamResult Check()
        {
            if (this.Score < 0 || this.Score > 100)
            {
                throw new InvalidOperationException("The score is must be bigger than 0 and less then 100");
            }
            else
            {
                return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
            }
        }
    }
}
