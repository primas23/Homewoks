using System;
using System.Collections.Generic;
using System.Linq;


namespace SortingHomework
{
    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sorts the specified collection via Recursive merge sort algorithm.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void Sort(IList<T> collection)
        {
            var sortedList = MergeSort(collection);

            collection.Clear();

            foreach (var item in sortedList)
            {
                collection.Add(item);
            }
        }

        /// <summary>
        /// Merge sort algirithm
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <returns></returns>
        private IList<T> MergeSort(IList<T> collection)
        {
            if (collection.Count <= 1)
            {
                return collection;
            }

            IList<T> leftList = new List<T>();
            IList<T> rightList = new List<T>();


            for (int i = 0; i < collection.Count; i++)
            {
                if (i % 2 > 0)
                {
                    leftList.Add(collection[i]);
                }
                else
                {
                    rightList.Add(collection[i]);
                }
            }

            leftList = MergeSort(leftList);
            rightList = MergeSort(rightList);
            
            return MergeElements(leftList, rightList);
        }

        /// <summary>
        /// Merges the elements.
        /// </summary>
        /// <param name="leftList">The left list.</param>
        /// <param name="rightList">The right list.</param>
        /// <returns></returns>
        private IList<T> MergeElements(IList<T> leftList, IList<T> rightList)
        {
             IList<T> result = new List<T>();

            while (this.NotEmpty(leftList) && this.NotEmpty(rightList))
            {
                if (leftList.First().CompareTo(rightList.First()) <= 0)
                {
                    this.MoveValueFromSourceToResult(leftList, result);
                }
                else
                {
                    this.MoveValueFromSourceToResult(rightList, result);
                }
            }

            while (this.NotEmpty(leftList))
            {
                this.MoveValueFromSourceToResult(leftList, result);
            }

            while (this.NotEmpty(rightList))
            {
                this.MoveValueFromSourceToResult(rightList, result);
            }

            return result;
        }

        /// <summary>
        /// Check if empty.
        /// </summary>
        /// <param name="leftList">The left list.</param>
        /// <returns></returns>
        private bool NotEmpty(IList<T> leftList)
        {
            return leftList.Count > 0;
        }

        /// <summary>
        /// Moves the value from source to result.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="result">The result.</param>
        private void MoveValueFromSourceToResult(IList<T> list, IList<T> result)
        {
            result.Add(list.First());
            list.RemoveAt(0);
        }
    }
}
