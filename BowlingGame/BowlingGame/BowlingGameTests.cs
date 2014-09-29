using NUnit.Framework;

namespace BowlingGame
{
    public class BowlingGameTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 20)]
        [TestCase(2, 40)]
        public void Sum_Of_All_Rolls(int roll, int expectedScore)
        {
            var bowlingGame = new BowlingGame();
            for (var i = 0; i < 20; i++)
            {
                bowlingGame.Roll(roll);
            }
            Assert.That(bowlingGame.TotalScore(), Is.EqualTo(expectedScore));
        }

        [Test]
        public void Should_Score_90_When_Alternate_9s_And_1s_Rolled()
        {
            var bowlingGame = new BowlingGame();
            for (var i = 0; i < 10; i++)
            {
                bowlingGame.Roll(9);
                bowlingGame.Roll(0);
            }

            Assert.That(bowlingGame.TotalScore(), Is.EqualTo(90));
        }

        [Test]
        public void Should_Score_20_When_Spare_Rolled_Then_5()
        {
            var bowlingGame = new BowlingGame();
            for (var i = 0; i < 3; i++)
            {
                bowlingGame.Roll(5);
            }
            for (var i = 0; i < 17; i++)
            {
                bowlingGame.Roll(0);
            }

            Assert.That(bowlingGame.TotalScore(), Is.EqualTo(20));
        }

        [Test]
        public void Should_Score_14_When_Strike_Rolled_Then_Two_1s()
        {
            var bowlingGame = new BowlingGame();
            bowlingGame.Roll(10);
            bowlingGame.Roll(1);
            bowlingGame.Roll(1);
            for (var i = 0; i < 16; i++)
            {
                bowlingGame.Roll(0);
            }

            Assert.That(bowlingGame.TotalScore(), Is.EqualTo(14));
        }

		[Test]
		public void Should_Score_300_When_Perfect_Game()
		{
			var bowlingGame = new BowlingGame();
			for (var i = 0; i < 12; i++)
			{
				bowlingGame.Roll(10);
			}

			Assert.That(bowlingGame.TotalScore(), Is.EqualTo(300));
		}

		[Test]
		public void Should_Score_33_When_Strike_Rolled_Then_Spare_Then_1()
		{
			var bowlingGame = new BowlingGame();
			bowlingGame.Roll(10);
			bowlingGame.Roll(7);
			bowlingGame.Roll(3);
			bowlingGame.Roll(1);
			bowlingGame.Roll(1);
			for (var i = 0; i < 14; i++)
			{
				bowlingGame.Roll(0);
			}

			Assert.That(bowlingGame.TotalScore(), Is.EqualTo(33));

		}

		[Test]
		public void Should_Score_34_When_Spare_Rolled_Then_Spare_Then_1()
		{
			var bowlingGame = new BowlingGame();
			bowlingGame.Roll(7);
			bowlingGame.Roll(3);
			bowlingGame.Roll(10);
			bowlingGame.Roll(1);
			bowlingGame.Roll(1);
			for (var i = 0; i < 14; i++)
			{
				bowlingGame.Roll(0);
			}

			Assert.That(bowlingGame.TotalScore(), Is.EqualTo(34));
		}

		[Test]
		public void Should_Score_Incomplete_Game()
		{
			var bowlingGame = new BowlingGame();

			bowlingGame.Roll(1);

			Assert.That(bowlingGame.TotalScore(), Is.EqualTo(1));
		}
    }
}
