using System.Collections.Generic;
using NUnit.Framework;

namespace MyStringBuilderTask
{
    public class MyStringBuilderTests
    {
        public static void TestAppend(string oldValue, string expectedResult)
        {
            var actualResult = new MyStringBuilder();
            SetOldValue(actualResult, oldValue);
            
            Assert.AreEqual(expectedResult, actualResult.ToString());
        }

        public static void TestClear(string oldValue)
        {
            var actualResult = new MyStringBuilder();
            SetOldValue(actualResult, oldValue);
            actualResult.Clear();
            Assert.AreEqual(new List<char>(), actualResult.Value);
        }

        private static void SetOldValue(MyStringBuilder sb, string oldValue)
        {
            var oldValueList = new List<char>();
            foreach (var cur in oldValue)
            {
                oldValueList.Add(cur);
            }

            sb.Value = oldValueList;
        }

        private static void IsEqualToString(MyStringBuilder sb, string expected)
        {
            
        }

        public static void TestToString()

        [TestCase(@"", new string[0])]
        [TestCase("text", new[] { "text" })]
        [TestCase("hello world", new[] { "hello", "world" })]
        [TestCase(@"kek    lol", new[] { @"kek", @"lol" })]
        [TestCase(@"""'kek'""", new[] { @"'kek'" })]
        [TestCase(@"'""kek""'", new[] { @"""kek""" })]
        [TestCase(@"""""", new[] { @"" })]
        [TestCase(@"'   '", new[] { @"   " })]
        [TestCase(@"""kek", new[] { @"kek" })]
        [TestCase(@"kek""\lol""prikol", new[] { @"kek", @"lol", @"prikol" })]
        [TestCase(@"""\\""", new[] { @"\" })]
        [TestCase(@"'\'\''", new[] { @"''" })]
        [TestCase(@"""\""""", new[] { @"""" })]
        [TestCase(@"  a", new[] { @"a" })]
        [TestCase(@"'kek ", new[] { @"kek " })]
        public static void RunTests(string input, string[] expectedOutput)
        {
            Test(input, expectedOutput);
        }
    }
}