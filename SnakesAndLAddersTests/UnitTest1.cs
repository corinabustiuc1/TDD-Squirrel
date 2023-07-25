using FluentAssertions;

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

        [Test]
        public void Move_Should_Return_1()
        {
            var result = Move(0, 1);
            result.Should().Be(1);
        }

        [Test]
        public void Move_Should_Return_3_ForMovement3()
        {
            var result = Move(0, 3);
            result.Should().Be(3);
        }

        public int Move(int position, int movement)
        {
            return position + movement;
        }

    }
}