//This file is for the tests which sort the words in the list in alphabethic order.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountYourWords;
using System.Collections.Generic;

namespace CountYourWordsTests
{
    [TestClass]
    public class WordSorterTests
    {
        private WordSorter _sorter;

        [TestInitialize]
        public void Setup() => _sorter = new WordSorter();

        [TestMethod]
        public void sortingTest1()
        {
            var wordDict = new Dictionary<string, int>
            {
                { "banana", 2 },
                { "apple", 5 },
                { "pear", 1 }
            };

            var expected = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("apple", 5),
                new KeyValuePair<string, int>("banana", 2),
                new KeyValuePair<string, int>("pear", 1)
            };
            var result = _sorter.SortingAlphabetically(wordDict);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void sortingTest2_WithFirstLetterSame()
        {
            var wordDict = new Dictionary<string, int>
            {
                { "apple", 5 },
                { "banana", 8 },
                { "cactus", 4 },
                { "beat", 5}
            };

            var expected = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("apple", 5),
                new KeyValuePair<string, int>("banana", 8),
                new KeyValuePair<string, int>("beat", 5),
                new KeyValuePair<string, int>("cactus", 4)
            };
            var result = _sorter.SortingAlphabetically(wordDict);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void sortingTest3_WithLastLetterDifferent()
        {
            var wordDict = new Dictionary<string, int>
            {
                { "apple", 5 },
                { "banana", 8 },
                { "banane", 9 },
                { "cactus", 4 },
                { "beat", 5 }
            };

            var expected = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("apple", 5),
                new KeyValuePair<string, int>("banana", 8),
                new KeyValuePair<string, int>("banane", 9),
                new KeyValuePair<string, int>("beat", 5),
                new KeyValuePair<string, int>("cactus", 4)
            };
            var result = _sorter.SortingAlphabetically(wordDict);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void sortingTest4_With3thLetterDifferent()
        {
            var wordDict = new Dictionary<string, int>
            {
                { "apple", 5 },
                { "apale", 8 },
                { "banana", 9 },
                { "cactus", 4 },
                { "beat", 5 }
            };

            var expected = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("apale", 8),
                new KeyValuePair<string, int>("apple", 5),
                new KeyValuePair<string, int>("banana", 9),
                new KeyValuePair<string, int>("beat", 5),
                new KeyValuePair<string, int>("cactus", 4)
            };
            var result = _sorter.SortingAlphabetically(wordDict);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}