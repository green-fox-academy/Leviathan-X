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

        public void StatusShow()
        {
            Console.WriteLine("\nStatus: " +
                $"\n\nDice 1: {dice[0]}" +
                $"\n\nDice 2: {dice[1]}" +
                $"\n\nDice 3: {dice[2]}" +
                $"\n\nDice 4: {dice[3]}" +
                $"\n\nDice 5: {dice[4]}" +
                $"\n\nDice 6: {dice[5]}");
        }

        public void StatusReset()
        {
            dice[0] = 0;
            dice[1] = 0;
            dice[2] = 0;
            dice[3] = 0;
            dice[4] = 0;
            dice[5] = 0;
        }

        public bool CheckWin()
        {
            foreach (var item in dice)
            {
                if (item != 6) return false;
            }
            Console.WriteLine("\n\n\t*****************************************************" +
                "\n\t*****************************************************" +
                "\n\t*****************************************************" +
                "\n\t***********************WINNER!***********************" +
                "\n\t*****************************************************" +
                "\n\t*****************************************************" +
                "\n\t*****************************************************");
            if (DaGame.rerollsNum < DaGame.highScore || DaGame.highScore == 0)
            {
                DaGame.highScore = DaGame.rerollsNum;
            }
            DaGame.rerollsNum = 0;
            return true;
        }

    }
}