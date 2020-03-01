using System;
using System.Text;
using System.Collections.Generic;

namespace _04__Count_Letters
{
    class Program
    {
        public static Dictionary<char, int> StartCount(string input)
        {
            Dictionary<char, int> myDic = new Dictionary<char, int>();
            char[] chario = input.ToCharArray();

            foreach (var item in chario)
            {
                if (myDic.ContainsKey(item))
                {
                    myDic[item] += 1;
                }
                else
                {
                    myDic.Add(item, 1);
                }
            }
            return myDic;
        }

        static void Main(string[] args)
        {
            string nonsense = "Dude, you've got a really dirty mind. What's wrong with you?";
            Dictionary<char, int> myWonderfulDic = StartCount(nonsense);
            
            Console.WriteLine("\nCloser Look At myDic:" +
                "\nKey is for Letter, Value is for Number Of Times Used.\n");
            int num = 1;
            int totes = 0;
            foreach (char key in myWonderfulDic.Keys)
            {
                int value;
                myWonderfulDic.TryGetValue(key, out value);
                totes += value;
                Console.WriteLine($"{num}.\nKey: \"{key}\" Value: {value}");
                num++;
            }
            Console.WriteLine($"\n--Total letters: {totes}");
        }
    }
}
