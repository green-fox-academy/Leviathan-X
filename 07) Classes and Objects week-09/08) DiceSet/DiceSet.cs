using System;
using System.Collections.Generic;
using System.Text;

namespace _08__DiceSet
{
    class DiceSet
    {
        private Random randomValue = new Random();
        private int[] dice = new int[6];

        public int[] Roll()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = randomValue.Next(1, 7);
            }

            return dice;
        }

        public int[] GetCurrent()
        {
            return dice;
        }

        public int GetCurrent(int i)
        {
            return dice[i];
        }

        public void Reroll()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = randomValue.Next(1, 7);
            }
        }

        public void Reroll(int k)
        {
            dice[k] = randomValue.Next(1, 7);
        }

        public void Win()
        {
            int num = 0;
            foreach (var item in dice)
            {
                if (item == 6) num++;
            }
            if (num == 6)
            {
                Console.WriteLine("\n\n\t*****************************************************" +
                    "\n\t*****************************************************" +
                    "\n\t*****************************************************" +
                    "\n\t***********************WINNER!***********************" +
                    "\n\t*****************************************************" +
                    "\n\t*****************************************************" +
                    "\n\t*****************************************************");
            }
            num = 0;
        }
    }
}
