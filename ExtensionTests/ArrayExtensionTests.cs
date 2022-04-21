using MyCSharpExtensions;
using NUnit.Framework;
using System;

namespace ExtensionTests
{
    public class ArrayExtensionTests
    {
        [Test]
        [TestCase(new int[] { 5, 2, 8, 3, 1, 4, 7, 6, 10, 9 })]
        public void Sort(int[] array)
        {
            var arrayClone = array;

            Array.Sort(array);
            arrayClone.Sort();
            Assert.AreEqual(array, arrayClone, "The incrementing arrays are not equal");
        }

        [Test]
        [TestCase(new int[] { 5, 2, 8, 3, 1, 4, 7, 6, 10, 9 })]
        public void SortWithComparison(int[] array)
        {
            var arrayClone = array;

            Array.Sort(array, (a, b) => b.CompareTo(a));
            arrayClone.Sort((a, b) => b.CompareTo(a));
            Assert.AreEqual(array, arrayClone, "The decrementing arrays are not equal");
        }
    }
}
