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
        /// <exception cref="NullReferenceException"></exception>
        public CSharpExam(int score)
        {
            if (score < 0)
            {
                throw new NullReferenceException();
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
        /// Checks this instance.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public override ExamResult Check()
        {
            if (this.Score < 0 || this.Score > 100)
            {
                throw new InvalidOperationException();
            }
            else
            {
                return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
            }
        }
    }
}
