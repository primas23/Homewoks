// <copyright file="Chef.cs" company="Primas">
//     Copyright (c) Primas. All rights reserved.
// </copyright>
// <author>Petar Petrov</author>
namespace Task01.ClassChefInCSharp
{
    /// <summary>
    /// The Chef class which cooks Vegetables
    /// </summary>
    public class Chef
    {
        /// <summary>
        /// Void method that indicates the class to cook
        /// </summary>
        public void Cook()
        {
            Bowl bowl = this.GetBowl();

            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);
            bowl.Add(potato);
            
            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);
            bowl.Add(carrot);
        }

        /// <summary>
        /// Gets the bowl.
        /// </summary>
        /// <returns>In this case returns a new instance of the class Bowl</returns>
        private Bowl GetBowl()
        {
            // ... 
            return new Bowl();
        }

        /// <summary>
        /// Gets the carrot.
        /// </summary>
        /// <returns>In this case returns a new instance of the class Carrot</returns>
        private Carrot GetCarrot()
        {
            // ...
            return new Carrot();
        }

        /// <summary>
        /// Gets the potato.
        /// </summary>
        /// <returns>In this case returns a new instance of the class Potato</returns>
        private Potato GetPotato()
        {
            // ...
            return new Potato();
        }

        /// <summary>
        /// Cuts the specified potato.
        /// </summary>
        /// <param name="vegetable">The vegetable.</param>
        private void Cut(Vegetable vegetable)
        {
            // ...
        }

        /// <summary>
        /// Peels the specified vegetable.
        /// </summary>
        /// <param name="vegetable">The vegetable.</param>
        private void Peel(Vegetable vegetable)
        {
            // ...
        }
    }
}
