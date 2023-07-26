using FluentAssertions;

namespace SnakeTest
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
        public void MoveShouldReturn_3_ForMovement3() 
        {
                    //position, movement
            var result = Move(0, 3);
            result.Should().Be(3);
        }

        [Test]
        public void MoveShouldReturn_eins()
        {
            var result = Move(0, 1);
            result.Should().Be(1);
        }
        [TestCase(0,1,1)]
        [TestCase(0,3,3)]
        [TestCase(4, 5, 9)]

        public void MoveShouldReturn_ExpectedField(int position, int movement, int expected)
        {
            var result = Move(position, movement);
            result.Should().Be(expected);
        }
        public static int Move(int initPos, int movement)
        {
            return initPos + movement;
        }


        [Test]
        public void ThrowDice_ShouldReturIntnRange0to6()
        {
            var result = ThrowDice();
            result.Should().BeOfType(typeof(int));
            result.Should().BeInRange(1,6);
        }

        private static int ThrowDice()
        {
            var random  = new Random();
            var result = random.Next(1,6);
            return result;
        }
        //have a method that calls ThrowDice() and Move() one after the other
        [Test]
        public void ThrowDiceAndMove_should_Return_RangeBetween1and6() 
        {
            var result = ThrowDiceAndMove(0);
            result.Should().BeInRange(1,6);
        }
        private static int ThrowDiceAndMove(int pos)
        {
           var rand = ThrowDice();
           var result = Move(pos,rand);

           return result;
        }

      

    }
}