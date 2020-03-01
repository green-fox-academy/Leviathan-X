using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Count_Letters_Test
{
    public class UnitTest1
    {
        public Dictionary<char, int> StartCount(string input)
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

        [Theory]
        [InlineData("Yo yo yo, son!")]
        public void RunTest(string testInput)
        {
            Dictionary<char, int> myWonderfulDic = StartCount(testInput);

            // Console.WriteLine("\nCloser Look At myDic:" +
            //    "\nKey is for Letter, Value is for Number Of Times Used.\n");
            int num = 1;
            int totes = 0;
            foreach (char key in myWonderfulDic.Keys)
            {
                int value;
                myWonderfulDic.TryGetValue(key, out value);
                totes += value;
                // Console.WriteLine($"{num}.\nKey: \"{key}\" Value: {value}");
                num++;
            }
            // Console.WriteLine($"\n--Total letters: {totes}");

            //Assert.True(totes == 14);
            Assert.Equal(14, totes);
        }
    }
}
