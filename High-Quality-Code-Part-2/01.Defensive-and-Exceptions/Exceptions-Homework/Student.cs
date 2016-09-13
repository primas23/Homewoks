// <copyright file="Student.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Student class
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="exams">The exams.</param>
        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            if (firstName == null)
            {
                Console.WriteLine("Invalid first name!");
                Environment.Exit(0);
            }

            if (lastName == null)
            {
                Console.WriteLine("Invalid first name!");
                Environment.Exit(0);
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

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
        /// Gets or sets the exams.
        /// </summary>
        /// <value>
        /// The exams.
        /// </value>
        public IList<Exam> Exams { get; set; }

        /// <summary>
        /// Checks the exams.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception">Wow! Error happened!!!</exception>
        public IList<ExamResult> CheckExams()
        {
            if (this.Exams == null)
            {
                throw new Exception("Wow! Error happened!!!");
            }

            if (this.Exams.Count == 0)
            {
                Console.WriteLine("The student has no exams!");
                return null;
            }

            IList<ExamResult> results = new List<ExamResult>();
            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i].Check());
            }

            return results;
        }

        /// <summary>
        /// Calculates the average exam result in percentage.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams == null)
            {
                // Cannot calculate average on missing exams
                throw new Exception();
            }

            if (this.Exams.Count == 0)
            {
                // No exams --> return -1;
                return -1;
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] = 
                    ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}
