using Pairprogramming;
namespace CoinsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, "I")]
        [TestCase(0, "")]
        [TestCase(9999, "MMMMMMMMMCMXCIX")]
        public void GivenYearsReturnRomanYears(int years, string result)
        {
            Assert.That(Program.RomanNumerials(years).Equals(result));
        }
        [TestCase(2000)]
        [TestCase(-1)]
        public void OutOfRangeException(int year)
        {
            Assert.That(() => Program.RomanNumerials(year), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}