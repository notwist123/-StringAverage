using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringAverageKata
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void SampleTests()
        {
            Assert.AreEqual("four", Kata.AverageString("zero nine five two"));
            Assert.AreEqual("three", Kata.AverageString("four six two three"));
            Assert.AreEqual("three", Kata.AverageString("one two three four five"));
            Assert.AreEqual("four", Kata.AverageString("five four"));
            Assert.AreEqual("zero", Kata.AverageString("zero zero zero zero zero"));
            Assert.AreEqual("two", Kata.AverageString("one one eight one"));
            Assert.AreEqual("n/a", Kata.AverageString(""));
        }
    }

    public class Kata
    {
        private static string[] stringsOfNumbers = { "zero", "one", "two", "three", "four", "five", "six" ,"seven", "eight", "nine"};
        private static String[] _numbers;
        private static int sum;

        public static string AverageString(string str)
        {
            _numbers = str.Split(' ');
            sum = 0;
            foreach (string s in _numbers)
            {
                if (isNotRegular(s)) return "n/a";
                sum = sum + stringTransToNumber(s);
            }
            
            return stringsOfNumbers[sum / _numbers.Length];
        }

        private static int stringTransToNumber(string str)
        {
            int i;
            for (i = 0; i < stringsOfNumbers.Length; i++)
            {
                if (str == stringsOfNumbers[i]) break;
            }
            return i;
        }

        private static bool isNotRegular(string str)
        {
            return (str == "") || (!stringsOfNumbers.Contains(str));
        }
    }
}
