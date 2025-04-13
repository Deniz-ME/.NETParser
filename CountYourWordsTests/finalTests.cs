using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using CountYourWords;

namespace CountYourWordsTests
{
    [TestClass]
    public class FinalTest
    {
        [TestMethod]
        public void TestFullProgramOutput()
        {

            var inputText = "The big brown fox number 4 jumped over the lazy dog. " +
                            "THE BIG BROWN FOX JUMPED OVER THE LAZY DOG. The Big Brown Fox 123 !!";
            var filePath = "test_input.txt";
            File.WriteAllText(filePath, inputText);

            var processor = new WordProcessor();
            var counter = new WordCounter();
            var sorter = new WordSorter();
            var program = new Program(processor, counter, sorter);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                program.Run(filePath);

                var output = sw.ToString();
                var expected = string.Join("\n", new[]
                    {
                        "Number of words: 23",
                        "",
                        "big 3",
                        "brown 3",
                        "dog 2",
                        "fox 3",
                        "jumped 2",
                        "lazy 2",
                        "number 1",
                        "over 2",
                        "the 5"
                    });
                Assert.IsTrue(output.Contains(expected));
            }
        }
    }
}
