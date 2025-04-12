//This file is for the test which counts the words in the list.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountYourWords;
using System.Collections.Generic;

namespace CountYourWordsTests
{
    [TestClass]
    public class WordCounterTests
    {
        private WordCounter _processor;

        [TestInitialize]
        public void Setup() => _processor = new WordCounter();

        [TestMethod]

        public void wordCountTest1()
        {
            var input = new List<string> { "the", "fox", "the", "dog", "fox" };
            var result = _processor.CountWords(input);

            var expected = new Dictionary<string, int>
            {
                {"the", 2},
                {"fox", 2},
                {"dog", 1}

            };
            CollectionAssert.AreEquivalent(expected, result);

        }

        [TestMethod]
        public void emptyList()
        {
            var input = new List<string>();
            var result = _processor.CountWords(input);

            Assert.AreEqual(0, result.Count);
            
        }

        [TestMethod]
        public void wordCountTest2()
        {
            var input = new List<string>{ "the", "cat","fox", "the", "dog", "fox", "fox", "fox", "fox", "fox", "fox", "fox" };
            var result = _processor.CountWords(input);

            var expected = new Dictionary<string, int>
            {
                {"the", 2},
                {"fox", 8},
                {"dog", 1},
                {"cat", 1}

            };

            CollectionAssert.AreEquivalent(expected, result);   
        }

        [TestMethod]
        public void singleWord()
        {
            var input = new List<string>{"fox"};
            var result = _processor.CountWords(input);

            Assert.AreEqual(1, result["fox"]);
            Assert.AreEqual(1, result.Count);
            
        }

    }
}