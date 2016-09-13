// <copyright file="Figure.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace Abstraction
{
    /// <summary>
    /// The base figure class
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Calculates the perimeter.
        /// </summary>
        /// <returns>The perimeter.</returns>
        public abstract double CalcPerimeter();

        /// <summary>
        /// Calculates the surface.
        /// </summary>
        /// <returns>The surface.</returns>
        public abstract double CalcSurface();
    }
}
