using System;
using System.IO;
using System.Collections.Generic;

namespace CountYourWords
{
    class Program(IWordProcessor processor, IWordCounter counter, IWordSorter sorter)
    {   
        private readonly IWordProcessor _processor = processor;
        private readonly IWordCounter _counter = counter;
        private readonly IWordSorter _sorter = sorter;

        public void Run(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("input.txt not found.");
                return;
            }

            string textOutOfFile = File.ReadAllText(filePath);
            
            var onlyWords = _processor.CleanText(textOutOfFile);
            var wordCounts = _counter.CountWords(onlyWords);
            var sortedWords = _sorter.SortingAlphabetically(wordCounts);

            Console.WriteLine($"\nNumber of words: {onlyWords.Count}\n");
            foreach (var pair in sortedWords)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
        }
        static void Main(string[] args)
        {
            var processor = new WordProcessor();
            var counter = new WordCounter();
            var sorter = new WordSorter();

            var parser = new Program(processor, counter, sorter);
            parser.Run("CountYourWords/input.txt");
        }
    }
}
