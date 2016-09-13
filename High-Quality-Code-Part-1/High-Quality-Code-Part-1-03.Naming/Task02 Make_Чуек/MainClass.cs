namespace Task02_Make_Чуек
{
    /// <summary>
    /// The main class
    /// </summary>
    internal class MainClass
    {
        /// <summary>
        /// The gender of person
        /// </summary>
        internal enum Gender
        {
            /// <summary>
            /// The male
            /// </summary>
            Male,

            /// <summary>
            /// The female
            /// </summary>
            Female
        }

        /// <summary>
        /// Creates the person.
        /// </summary>
        /// <param name="age">The age.</param>
        public void CreatePerson(int age)
        {
            Person newPerson = new Person();
            newPerson.Age = age;

            if (age % 2 == 0)
            {
                newPerson.Name = "Батката";
                newPerson.Gender = Gender.Male;
            }
            else
            {
                newPerson.Name = "Мацето";
                newPerson.Gender = Gender.Female;
            }
        }

        /// <summary>
        /// Person class
        /// </summary>
        internal class Person
        {
            /// <summary>
            /// Gets or sets the gender.
            /// </summary>
            /// <value>
            /// The gender.
            /// </value>
            public Gender Gender { get; set; }

            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the age.
            /// </summary>
            /// <value>
            /// The age.
            /// </value>
            public int Age { get; set; }
        }
    }
}