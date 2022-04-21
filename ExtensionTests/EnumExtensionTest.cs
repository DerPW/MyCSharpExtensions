using MyCSharpExtensions;
using NUnit.Framework;
namespace ExtensionTests
{
    public class EnumExtensionTest
    {
        enum TestEnum
        {
            [System.ComponentModel.Description("First Value")]
            FirstValue,
            SecondValue,
            ThirdValue,
        }

        [Test]
        public void GetDescription()
        {
            Assert.AreEqual("First Value", TestEnum.FirstValue.GetDescription(), "The expected value is not the correct description");
            Assert.AreEqual("SecondValue", TestEnum.SecondValue.GetDescription(), "The expected value is not the correct description");
        }
    }
}
