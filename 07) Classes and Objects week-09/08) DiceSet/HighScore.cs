using System;
using System.Collections.Generic;
using System.Text;

namespace _08__DiceSet
{
    class HighScore
    {
        private int highScore = 100;
        private int currentScore = DaGame.rerollsNum;

        public HighScore()
        {
            if (currentScore < highScore)
            {
                highScore = currentScore;
            }
        }

        public int Get()
        {
            return highScore;
        }

    }
}
