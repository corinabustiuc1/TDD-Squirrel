using FluentAssertions;
using SnakesAndLadders;

namespace SnakesAndLAddersTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }



        [TestCase(0,1,1)]
        [TestCase(0,3,3)]
        [TestCase(4,3,7)]
        [TestCase(14,3,17)]
        public void Move_Should_Return_ExpectedField(int position, int movement, int expected)
        {
            var result = PieceMover.Move(position, movement);
            result.Should().Be(expected);
        }


        [Test]
        public void RollDie_Should_Return_IntInRange1To6()
        {
            var result = PieceMover.RollDie();
            result.Should().BeOfType(typeof(int));
            result.Should().BeInRange(1, 6);

        }

        [Test]
        public void RollDie_Should_Return_AllIntegersBetween1And6()
        {
            var results = new List<int>();
            for (var i = 0; i < 100; i++)
            {
                var result = PieceMover.RollDie();
                results.Add(result);
            }

            results.Should().Contain(1);
            results.Should().Contain(2);
            results.Should().Contain(3);
            results.Should().Contain(4);
            results.Should().Contain(5);
            results.Should().Contain(6);
        }

        [Test]
        public void RollDieAndMove_Should_Return_RangeBetween1And6()
        {
            var result = PieceMover.RollDieAndMove(0);
            result.Should().BeInRange(1, 6);
        }
    }
}