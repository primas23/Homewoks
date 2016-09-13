// <copyright file="Circle.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace Abstraction
{
    using System;

    /// <summary>
    /// The Circle figure class
    /// </summary>
    /// <seealso cref="Abstraction.Figure" />
    public class Circle : Figure
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">The radius.</param>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Gets or sets the radius.
        /// </summary>
        /// <value>
        /// The radius.
        /// </value>
        public double Radius { get; set; }

        /// <summary>
        /// Calculates the perimeter.
        /// </summary>
        /// <returns>
        /// The perimeter.
        /// </returns>
        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        /// <summary>
        /// Calculates the surface.
        /// </summary>
        /// <returns>
        /// The surface.
        /// </returns>
        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
