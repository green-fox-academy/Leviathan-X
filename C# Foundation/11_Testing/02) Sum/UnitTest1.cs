using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace _02__Sum
{
    //Create a sum method in your class which takes a List of integers as parameter
    //It should return the sum of the elements in the list
    
    //Follow these steps:
    //Create an xUnit project
    //Add a Test class to your project
    //Add a new Test case in it
    //Instantiate your class (arrange, act, assert)
    //create a list of integers
    //use the Assert.Equal() to test the result of the created sum method
    //Run them
    
    //Create different tests where you test your method with:
    //an empyt list
    //a list that has one element in it
    //a list that has multiple elements in it
    //a null
    //Run them
    //Fix your code if needed

    public class UnitTest1
    {
        Summie summie = new Summie();
        public static List<int> Input = new List<int>() { 4, 5, 7, 12 };

        [Theory]
        [InlineData(28, new int[]{ 4, 5, 7, 12 })]
        // Putting "Input" in it doesn't work!! 
        // Probably on purpose, because they don't want it to be dependent

        [InlineData(1, new int[] { 1 })]
        [InlineData(0, new int[] { })]
        //[InlineData(0, null)]


        public void TestMethod1(int outputInt, int[] outputList)
        {
            Assert.Equal(outputInt, summie.Sum(outputList.ToList()));
        }

        List<int> nullio = null;
        [Fact]
        public void TestMethod2()
        {
            Assert.Equal(0, summie.Sum(nullio));
        }
    }
}
