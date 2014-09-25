using System.Collections.Generic;
using System.Linq;

namespace BowlingGame
{
    internal class BowlingGame
    {
        private readonly List<int> _scoreCard = new List<int>();

        public int TotalScore()
        {
            /*for (int i = 0; i < 20; i++)
            {
                if (_scoreCard.Last() == 10)
                {
                    
                }
            } */

            var score = 0;
            for (int rollIndex = 0; rollIndex < 20; rollIndex+=2)
            {
                if (SpareScoredInFrame(rollIndex))
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
