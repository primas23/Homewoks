using System;
using System.Collections.Generic;

namespace SortingHomework
{
    public interface ISorter<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sorts the specified collection.
        /// </summary>
        /// <param name="collection">The collection.</param>
        void Sort(IList<T> collection);
    }

}
