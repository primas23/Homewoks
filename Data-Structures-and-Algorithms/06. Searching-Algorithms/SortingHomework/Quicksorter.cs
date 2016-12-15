using System;
using System.Collections.Generic;

namespace SortingHomework
{
    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sorts the specified collection.
        /// </summary>
        /// <param name="collection">The collection.</param>
        public void Sort(IList<T> collection)
        {
            Quicksort(collection, 0, collection.Count - 1);
        }

        /// <summary>
        /// Quicksorts the specified elements.
        /// </summary>
        /// <param name="elements">The elements.</param>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        private static void Quicksort(IList<T> elements, int left, int right)
        {
            int i = left;
            int j = right;

            T pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    T tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
}
