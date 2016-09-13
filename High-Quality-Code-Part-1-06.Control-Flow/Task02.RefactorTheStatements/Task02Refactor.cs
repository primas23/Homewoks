// <copyright file="Task02Refactor.cs" company="Primas">
//     Copyright (c) Primas. All rights reserved.
// </copyright>
// <author>Petar Petrov</author>
namespace Task02.RefactorTheStatements
{
    /// <summary>
    /// A class created for compiling the code
    /// </summary>
    internal class Task02Refactor
    {
        /// <summary>
        /// The maximum x
        /// </summary>
        private const int MAX_X = 4;

        /// <summary>
        /// The minimum x
        /// </summary>
        private const int MIN_X = 4;

        /// <summary>
        /// The maximum y
        /// </summary>
        private const int MAX_Y = 4;

        /// <summary>
        /// The minimum y
        /// </summary>
        private const int MIN_Y = 4;

        /// <summary>
        /// The x
        /// </summary>
        private int x;

        /// <summary>
        /// The y
        /// </summary>
        private int y;

        /// <summary>
        /// The should not visit cell
        /// </summary>
        private bool shouldNotVisitCell;

        /// <summary>
        /// Initializes a new instance of the <see cref="Task02Refactor"/> class.
        /// </summary>
        public Task02Refactor()
        {
            // First part of the homework
            Potato potato = new Potato();

            // ... 
            if (potato != null)
            {
                if (potato.HasNotBeenPeeled || potato.IsRotten)
                {
                    // ...
                }
                else
                {
                    this.Cook(potato);
                }
            }

            // Second part of the homework
            if ((MIN_X > x || x > MAX_X) || (MIN_Y > y || y > MAX_Y) || shouldNotVisitCell)
            {
                VisitCell();
            }
        }

        /// <summary>
        /// Visits the cell.
        /// </summary>
        private void VisitCell()
        {
            // ..
        }

        /// <summary>
        /// Cooks the specified potato.
        /// </summary>
        /// <param name="potato">The potato.</param>
        private void Cook(Potato potato)
        {
            // ...
        }
    }
}
