using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("peanut", false)]
        [InlineData("noon", true)]
        [InlineData("triscuit", false)]
        [InlineData("deified", true)]
        [InlineData("puzzle", false)]

        public void MyTest(string word, bool expected)
        {
            var test = new WordSmith();

            bool actual = test.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
