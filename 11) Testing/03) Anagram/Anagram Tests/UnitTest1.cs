using System;
using System.Linq;
using Xunit;

namespace Anagram_Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Cold Taco", "coat clod")]
        public void TestMethod1(string value1, string value2)
        {
            var newTest = new Anagram(value1, value2);
            Assert.True(newTest.SortInput());
        }
    }
}
