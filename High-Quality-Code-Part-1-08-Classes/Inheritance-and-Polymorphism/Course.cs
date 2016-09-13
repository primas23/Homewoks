// <copyright file="Course.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;

    /// <summary>
    /// The Course base class
    /// </summary>
    public class Course
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the teacher.
        /// </summary>
        /// <value>
        /// The name of the teacher.
        /// </value>
        public string TeacherName { get; set; }

        /// <summary>
        /// Gets or sets the students.
        /// </summary>
        /// <value>
        /// The students.
        /// </value>
        public IList<string> Students { get; set; }
        
        /// <summary>
        /// Gets the students as string.
        /// </summary>
        /// <returns>The students in a string format</returns>
        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
