using NUnit.Framework;
using StringCalculator.App;

namespace StringCalculator.Tests
{
    [TestFixture]
    public class StringConverterTests
    {
        [Test]
        public void Empty_string_returns_int_0()
        {
            var stringOfNumbers = " ";
            var stringConverter = new Converter();

            var result = stringConverter.Add(stringOfNumbers);

            Assert.AreEqual(0, result);
        }
        [Test]
        public void String_of_1_returns_int_1()
        {
            var stringOfNumbers = "1";
            var stringConverter = new Converter();

            var result = stringConverter.Add(stringOfNumbers);

            Assert.AreEqual(1, result);
        }
    }
}