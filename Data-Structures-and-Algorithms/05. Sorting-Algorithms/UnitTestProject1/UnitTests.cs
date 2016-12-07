using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SortingHomework;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTests
    {
        private readonly List<int> list;

        public UnitTests()
        {
            this.list = GenerateBigList();
        }

        private static List<int> GenerateBigList()
        {
            List<int> list = new List<int>();

            var randomGenerator = new Random();

            for (var i = 0; i < 8; i++)
            {
                list.Add(randomGenerator.Next());
            }

            return list;
        }

        [TestMethod]
        public void SelectionSort()
        {
            var collection = new SortableCollection<int>(this.list);

            collection.Sort(new SelectionSorter<int>());

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] <= collection.Items[i + 1]);
            }
        }
        

        [TestMethod]
        public void QuickSort()
        {
            var collection = new SortableCollection<int>(this.list);

            collection.Sort(new Quicksorter<int>());

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] <= collection.Items[i + 1]);
            }
        }

        [TestMethod]
        public void MergeSort()
        {
            var collection = new SortableCollection<int>(this.list);

            collection.Sort(new MergeSorter<int>());

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] <= collection.Items[i + 1]);
            }
        }
    }
}