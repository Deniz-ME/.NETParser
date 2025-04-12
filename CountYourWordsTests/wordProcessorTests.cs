using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountYourWords;
using System.Collections.Generic;

namespace CountYourWordsTests
{
    [TestClass]
    public class WordProcessorTests
    {
        private WordProcessor _processor;

        [TestInitialize]
        public void Setup() => _processor = new WordProcessor();

        [TestMethod]
        public void CleanText_RemovesSpecialCharacters()
        {
            string input = "hello!! ##test@";
            var result = _processor.CleanText(input);

            var expected = new List<string> { "hello", "test" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CleanText_RemovesNumbers()
        {
            string input = "hello 2024 world123";
            var result = _processor.CleanText(input);

            var expected = new List<string> { "hello", "world" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CleanText_ConvertsToLowercase()
        {
            string input = "HELLO Test";
            var result = _processor.CleanText(input);

            var expected = new List<string> { "hello", "test" };
            CollectionAssert.AreEqual(expected, result);
        }

         [TestMethod]
        public void CleanText_TestForEveryPossibility()
        {
            string input = "Hello!! WORLD123 ##Test@ 2024;
            var result = _processor.CleanText(input);

            var expected = new List<string> { "hello", "world", "test" };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
