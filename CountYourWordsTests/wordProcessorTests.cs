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
        public void InputToLowercase()
        {
            string input = "HELLO TEst";
            var result = _processor.ToLowercase(input);

            Assert.AreEqual("hello test", result);
        }

        [TestMethod]
        public void RemoveNonLettersCharacters()
        {
            string input = "hello!! 2024 ##test@";
            var result = _processor.RemoveNonAlphabeticChar(input);

            Assert.AreEqual("hello test", result);
        }

        [TestMethod]
        public void SplitWords()
        {
            string input = "hello test";
            var result = _processor.SplitStringIntoList(input);

            var expected = new List<string> { "hello", "test" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveEmptyWords()
        {
            var input = new List<string> { "hello", "", "test", " " };
            var result = _processor.RemoveEmptyWordsAndSpaces(input);

            var expected = new List<string> { "hello", "test" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ProcessesEverythingTogether()
        {
            string input = "Hello!! WORLD123 ##Test@ 2024";
            var result = _processor.CleanText(input);

            var expected = new List<string> { "hello", "world", "test" };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
