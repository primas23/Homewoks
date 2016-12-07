using System;
using System.Collections.Generic;

namespace SortingHomework
{
    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sorts the specified collection.
        /// </summary>
        /// <param name="collection">The collection.</param>
        public void Sort(IList<T> collection)
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                var postionMin = i;

                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(collection[postionMin]) == -1)
                    {
                        postionMin = j;
                    }
                }

                if (postionMin != i)
                {
                    T temp = collection[i];
                    collection[i] = collection[postionMin];
                    collection[postionMin] = temp;
                }
            }
        }
    }
}