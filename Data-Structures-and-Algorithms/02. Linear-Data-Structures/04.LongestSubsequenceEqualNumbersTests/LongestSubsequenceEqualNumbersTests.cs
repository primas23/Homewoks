using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExtensions;
using _04.LongestSubsequenceEqualNumbers;

namespace _04.LongestSubsequenceEqualNumbersTests
{
    [TestClass]
    public class LongestSubsequenceEqualNumbersTests
    {
        [TestMethod]
        public void TheMethod_ShouldReturnFiveThatRepeatsTwoTimes_WhenCorrectEntryIsSupplied()
        {
            IList<int> list = new List<int>()
            {
                1, 2, 3, 4, 5, 5
            };

            Assert.AreEqual(new KeyValuePair<int, int>(5, 2), Startup.GetLongestSequence(list));
        }

        [TestMethod]
        public void TheMethod_ShouldReturnThreeThatRepeatsSixTimes_WhenCorrectEntryIsSupplied()
        {
            IList<int> list = new List<int>()
            {
                1, 2, 3, 3, 3, 3, 3, 3, 4, 5, 5
            };

            Assert.AreEqual(new KeyValuePair<int, int>(3, 6), Startup.GetLongestSequence(list));
        }

        [TestMethod]
        public void TheMethod_ShouldReturnOneThatRepeatsOne_WhenCorrectEntryIsSupplied()
        {
            IList<int> list = new List<int>()
            {
                1, 2, 3, 4, 5
            };

            Assert.AreEqual(new KeyValuePair<int, int>(1, 1), Startup.GetLongestSequence(list));
        }

        [TestMethod]
        public void TheMethod_ShouldThrowArgumnetNull_WhenNullListIsSupplied()
        {
            ThrowsAssert.Throws<ArgumentNullException>(() => Startup.GetLongestSequence(null));
        }
    }
}
