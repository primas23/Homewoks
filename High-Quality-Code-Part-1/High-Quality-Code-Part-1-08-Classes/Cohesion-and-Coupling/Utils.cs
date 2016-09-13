// <copyright file="Utils.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// The Utilities class
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Gets the file extension.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>The file extension if there is any</returns>
        /// <exception cref="ArgumentNullException">You must supply file name</exception>
        public static string GetFileExtension(string fileName)
        {
            ThrowExceptionIfNull(fileName);

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        /// <summary>
        /// Gets the file name without extension.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>The file name</returns>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            ThrowExceptionIfNull(fileName);

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }

        /// <summary>
        /// Calculates the 2D distance.
        /// </summary>
        /// <param name="x1">The x1.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="y2">The y2.</param>
        /// <returns>2D distance</returns>
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        /// <summary>
        /// Calculates the 3D distance.
        /// </summary>
        /// <param name="x1">The x1.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="z1">The z1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="y2">The y2.</param>
        /// <param name="z2">The z2.</param>
        /// <returns>3D distance</returns>
        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));
            return distance;
        }

        /// <summary>
        /// Calculates the cubic volume.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="depth">The depth.</param>
        /// <returns>The cubic volume.</returns>
        public static double CalcVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;

            return volume;
        }

        /// <summary>
        /// Calculates the diagonal xyz.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="depth">The depth.</param>
        /// <returns>The Distance</returns>
        public static double CalcDiagonalXyz(double width, double height, double depth)
        {
            double distance = CalcDistance3D(0, 0, 0, width, height, depth);
            return distance;
        }

        /// <summary>
        /// Calculates the diagonal between two points.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns>The Distance</returns>
        public static double CalcDiagonalBetweenTwoPoints(double width, double height)
        {
            double distance = CalcDistance2D(0, 0, width, height);
            return distance;
        }

        /// <summary>
        /// Throws the exception if null.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <exception cref="ArgumentNullException">You must supply file name</exception>
        private static void ThrowExceptionIfNull(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException("You must supply file name");
            }
        }
    }
}
