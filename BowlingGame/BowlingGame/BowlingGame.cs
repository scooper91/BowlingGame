using System.Collections.Generic;

namespace BowlingGame
{
    internal class BowlingGame
    {
        private readonly List<int> _scoreCard = new List<int>();


        public int TotalScore()
        {
			int rollCount = 0;

            var score = 0;
            for (var frameIndex = 0; frameIndex < 10; frameIndex += 1)
            {
                if (_scoreCard[rollCount] == 10)
                {
	                score += 10 + _scoreCard[rollCount + 1] + _scoreCard[rollCount + 2];
					rollCount++;
                }
                else if (_scoreCard[rollCount] + _scoreCard[rollCount + 1] == 10)
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

        public void Roll(int pinsRolled)
        {
            _scoreCard.Add(pinsRolled);
        }
    }
}
