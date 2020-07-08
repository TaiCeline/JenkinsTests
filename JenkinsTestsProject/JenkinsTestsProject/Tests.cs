using System;
using NUnit.Framework;

namespace JenkinsTestsProject
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestsLogWord()
        {
            var word = "Hello World";
            Console.WriteLine(word);
            Assert.AreEqual("Hello World", word);
        }
    }
}