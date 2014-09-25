using System.Collections.Generic;
using System.Linq;

namespace BowlingGame
{
    internal class BowlingGame
    {
        private readonly List<int> _scoreCard = new List<int>();

        public int TotalScore()
        {
            return _scoreCard.Sum();
        }

        public void Roll(int pinsRolled)
        {
            _scoreCard.Add(pinsRolled);
        }

        public void Spare()
        {
            /*foreach (var pinsRolled in _scoreCard)
            {

            }

            if (_scoreCard[1] + _scoreCard[2] == 10)
            {
                _scoreCard[3] *= 2;
            }*/
        }
    }
}
