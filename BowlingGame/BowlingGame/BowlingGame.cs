using System.Collections.Generic;

namespace BowlingGame
{
	internal class BowlingGame
	{
		private readonly List<int> _scoreCard = new List<int>();

		public int TotalScore()
		{
			IncompleteRolls();

			var rollCount = 0;
			var score = 0;

			for (var frameCount = 0; frameCount < 10; frameCount += 1)
			{

				if (StrikeRolled(rollCount))
				{
					score += 10 + _scoreCard[rollCount + 1] + _scoreCard[rollCount + 2];
					rollCount++;
				}
				else if (SpareRolled(rollCount))
				{
					score += 10 + _scoreCard[rollCount + 2];
					rollCount += 2;
				}
				else
				{
					score += _scoreCard[rollCount] + _scoreCard[rollCount + 1];
					rollCount += 2;
				}
			}
			return score;
		}

		private void IncompleteRolls()
		{
			var rollsScored = _scoreCard.Count;
			if (_scoreCard.Count < 21)
			{
				for (int i = 0; i < 21 - rollsScored; i++)
				{
					_scoreCard.Add(0);
				}
			}
		}

		private bool SpareRolled(int rollCount)
		{
			return _scoreCard[rollCount] + _scoreCard[rollCount + 1] == 10;
		}

		private bool StrikeRolled(int rollCount)
		{
			return _scoreCard[rollCount] == 10;
		}

		public void Roll(int pinsRolled)
		{
			_scoreCard.Add(pinsRolled);
		}
	}
}
