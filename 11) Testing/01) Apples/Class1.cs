using System;
using System.Linq;
using Xunit;

namespace _01__Apples
{

    //Create a class, with one method(eg. public string GetApple()) that returns a string (eg. "apple")
    //Create a test for that.
    //Create an xUnit project
    //Add a new Test case in it
    //Instantiate your class (arrange, act, assert)
    //Use the Assert.Equal()
    //The expected parameter should be the same string (eg. "apple")
    //The actual parameter should be the return value of the method(eg.myObject.GetApple())
    //Run the test
    //Change the expected value to make the test failing
    //Run the test
    //Fix the returned value to make the test succeeding again

    public class Class1
    {
        Apples apple = new Apples();

        [Fact]
        public void TestMethod1()
        {
            Assert.Equal("apple", apple.GetApple());
        }
    }
}
