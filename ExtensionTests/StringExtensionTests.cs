using MyCSharpExtensions;
using NUnit.Framework;

namespace ExtensionTests;

public class StringExtensionTests
{
    [Test]
    [TestCase("")]
    [TestCase(" ")]
    [TestCase("\t")]
    [TestCase("\n")]
    [TestCase("\r")]
    [TestCase(null)]
    [TestCase("Hello World")]
    public void IsNullOrWhiteSpace(string value)
    {
        Assert.AreEqual(string.IsNullOrWhiteSpace(value), value.IsNullOrWhiteSpace(), "IsNullOrWhiteSpace failed for value: {0}", value);
    }
}
