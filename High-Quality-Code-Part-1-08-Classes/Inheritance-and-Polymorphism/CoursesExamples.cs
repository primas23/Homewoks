// <copyright file="CoursesExamples.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The Example of the Courses class
    /// </summary>
    public class CoursesExamples
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Databases");
            Console.WriteLine(localCourse);

            localCourse.Lab = "Enterprise";
            Console.WriteLine(localCourse);

            localCourse.Students = new List<string>() { "Peter", "Maria" };
            Console.WriteLine(localCourse);

            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            Console.WriteLine(localCourse);

            OffsiteCourse offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development",
                "Mario Peshev", 
                new List<string>() { "Thomas", "Ani", "Steve" });

            Console.WriteLine(offsiteCourse);
        }
    }
}
