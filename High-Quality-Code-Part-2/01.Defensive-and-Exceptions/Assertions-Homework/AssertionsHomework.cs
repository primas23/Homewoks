// <copyright file="AssertionsHomework.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace Assertions_Homework
{
    using System;

    /// <summary>
    /// The Assertions Homework
    /// </summary>
    public class AssertionsHomework
    {
        /// <summary>
        /// Sorts a selection.
        /// </summary>
        /// <typeparam name="T">Any type of that implements IComparable</typeparam>
        /// <param name="arr">The array.</param>
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }

        /// <summary>
        /// Performs binary search
        /// </summary>
        /// <typeparam name="T">Any type of that implements IComparable</typeparam>
        /// <param name="arr">The array.</param>
        /// <param name="value">The value.</param>
        /// <returns>The index of the found value or -1 if not found</returns>
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        /// <summary>
        /// Finds the the index of the element with minimum value.
        /// </summary>
        /// <typeparam name="T">Any type of that implements IComparable</typeparam>
        /// <param name="arr">The array.</param>
        /// <param name="startIndex">The start index.</param>
        /// <param name="endIndex">The end index.</param>
        /// <returns>The index of the element with minimum value</returns>
        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        /// <summary>
        /// Swaps the specified values.
        /// </summary>
        /// <typeparam name="T">Any type</typeparam>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }

        /// <summary>
        /// Performs binary search.
        /// </summary>
        /// <typeparam name="T">Any type of that implements IComparable</typeparam>
        /// <param name="arr">The array.</param>
        /// <param name="value">The value.</param>
        /// <param name="startIndex">The start index.</param>
        /// <param name="endIndex">The end index.</param>
        /// <returns>The index of the found value or -1 if not found</returns>
        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        private static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 }; // TODO: Finish the homework

            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));

            SelectionSort(arr);

            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            SelectionSort(new int[0]); // Test sorting empty array
            SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(BinarySearch(arr, -1000));
            Console.WriteLine(BinarySearch(arr, 0));
            Console.WriteLine(BinarySearch(arr, 17));
            Console.WriteLine(BinarySearch(arr, 10));
            Console.WriteLine(BinarySearch(arr, 1000));
        }
    }
}
