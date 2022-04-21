using MyCSharpExtensions;
using NUnit.Framework;
using System.Collections.Generic;

namespace ExtensionTests
{
    public class EnumerableExtensionTests
    {
        [Test]
        [TestCase(0, 5, 2, new[] { 0, 2, 4, 6, 8 })]
        [TestCase(1, 4, 3, new[] { 1, 4, 7, 10 })]
        [TestCase(2, 3, 2, new[] { 2, 4, 6 })]
        [TestCase(3, 2, 3, new[] { 3, 6 })]
        [TestCase(4, 1, 4, new[] { 4 })]
        public void Range(int start, int count, int step, IEnumerable<int> expectedEnumerable)
        {
            var range = EnumerableExtensions.Range(start, count, step);
            Assert.AreEqual(expectedEnumerable, range, "The expected enumerable is not equal to the actual enumerable.");
        }
    }
}
