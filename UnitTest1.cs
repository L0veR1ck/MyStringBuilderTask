using System.Collections.Generic;
using NUnit.Framework;

namespace MyStringBuilderTask
{
    public class MyStringBuilderTests
    {
        public static void TestAppendString(string oldValue, string toAppend, string expectedResult)
        {
            var actualResult = new MyStringBuilder();
            actualResult.Value = GetListOfChars(oldValue);
            actualResult.Append(toAppend);
            Assert.AreEqual(GetListOfChars(expectedResult), actualResult.Value);
        }

        public static void TestClear(string oldValue)
        {
            var actualResult = new MyStringBuilder();
            actualResult.Value = GetListOfChars(oldValue);
            actualResult.Clear();
            Assert.AreEqual(new List<char>(), actualResult.Value);
        }

        public static void TestToString(string oldValue, string expectedResult)
        {
            var actualResult = new MyStringBuilder();
            actualResult.Value = GetListOfChars(oldValue);
            Assert.AreEqual(expectedResult, actualResult.ToString());
        }

        private static List<char> GetListOfChars(string oldString)
        {
            var newList = new List<char>();
            foreach (var cur in oldString)
                newList.Add(cur);

            return newList;
        }
    }
}