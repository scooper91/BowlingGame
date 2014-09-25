using System.Collections.Generic;
using System.Linq;

namespace BowlingGame
{
    internal class BowlingGame
    {
        private readonly List<int> _scoreCard = new List<int>();

        public int TotalScore()
        {
            var score = 0;
            var rollCount = 0;

            for (var rollIndex = 0; rollIndex < _scoreCard.Count; rollIndex += 2)
            {
                rollCount += 1;
                if (SpareScoredInFrame(rollIndex) && _scoreCard[rollIndex] == 10)
                {
                    rollCount -= 1;
                    _scoreCard.Add(0);
                    score += 10 + _scoreCard[rollIndex + 2] + _scoreCard[rollIndex + 3];
                } else if (SpareScoredInFrame(rollIndex))
                {
                    score += 10 + _scoreCard[rollIndex + 2];
                }
                else
                {
                    score += _scoreCard[rollIndex] + _scoreCard[rollIndex + 1];
                }
            }
            return score;
        }

        public void Roll(int pinsRolled)
        {
            _scoreCard.Add(pinsRolled);
        }

        private bool SpareScoredInFrame(int rollIndex)
        {
            return _scoreCard[rollIndex] + _scoreCard[rollIndex + 1] == 10;
        }
    }
}
