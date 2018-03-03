using NUnit.Framework;
using StringCalculator.App;

namespace StringCalculator.Tests
{
    [TestFixture]
    public class StringConverterTests
    {
        [Test]
        public void Empty_string_to_converter_should_return_blank_string()
        {
            var stringOfNumbers = " ";
            var stringConverter = new Converter();

            var result = stringConverter.Add(stringOfNumbers);

            Assert.AreEqual(0, result);
        }
    }
}