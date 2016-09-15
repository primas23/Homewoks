// <copyright file="SimpleMathExam.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace Exceptions_Homework
{
    using System;

    /// <summary>
    /// SimpleMathExam class
    /// </summary>
    /// <seealso cref="Exceptions_Homework.Exam" />
    public class SimpleMathExam : Exam
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleMathExam"/> class.
        /// </summary>
        /// <param name="problemsSolved">The number of the solved problems.</param>
        public SimpleMathExam(int problemsSolved)
        {
            if (problemsSolved < 0)
            {
                throw new ArgumentOutOfRangeException("The number of problems can not be less than 0!");
            }

            if (problemsSolved > 2)
            {
                throw new ArgumentOutOfRangeException("The number of problems can not be greather than 2");
            }

            this.ProblemsSolved = problemsSolved;
        }

        /// <summary>
        /// Gets the problems solved.
        /// </summary>
        /// <value>
        /// The problems solved.
        /// </value>
        public int ProblemsSolved { get; private set; }

        /// <summary>
        /// Checks this instance.
        /// </summary>
        /// <returns>The Exam result</returns>
        public override ExamResult Check()
        {
            if (this.ProblemsSolved == 0)
            {
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            }
            else if (this.ProblemsSolved == 1)
            {
                return new ExamResult(4, 2, 6, "Average result: nothing done.");
            }
            else if (this.ProblemsSolved == 2)
            {
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }

            throw new ArgumentOutOfRangeException("Invalid number of problems solved!");
        }
    }
}
