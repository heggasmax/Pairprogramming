using MaxGetcoinsandnotes;
namespace Coins_test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(20, "£20: 1, £10: 0, £5: 0, £1: 0, 50p: 0, 20p: 0, 10p: 0, 5p: 0, 2p: 0, 1p: 0")]
        [TestCase(149.89, "£20: 7, £10: 0, £5: 1, £1: 4, 50p: 1, 20p: 1, 10p: 1, 5p: 1, 2p: 1, 1p: 1")]
        [TestCase(4549.69, "£20: 227, £10: 0, £5: 1, £1: 4, 50p: 1, 20p: 0, 10p: 1, 5p: 1, 2p: 1, 1p: 1")]
        public void GiveCoinsReturnsCorrectChange(double coins, string result)
        {

            Assert.That(Program.GetCoinsAndNotes(coins).Equals(result));
        }

        [TestCase(-1)]
        public void OutOfRangeException(double coins)
        {
            Assert.That(() => Program.GetCoinsAndNotes(coins), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
    }
}