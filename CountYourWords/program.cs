using System;
using System.IO;
using System.Collections.Generic;

namespace CountYourWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "CountYourWords/input.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("input.txt not found.");
                return;
            }

            string textOutOfFile = File.ReadAllText(filePath);
            
            var processor = new WordProcessor();
            var onlyWords = processor.CleanText(textOutOfFile);
  
            var counter = new WordCounter();
            var wordCounts = counter.CountWords(onlyWords);

            var sorter = new WordSorter();
            var sortedWords = sorter.SortingAlphabetically(wordCounts);

            Console.WriteLine($"\nNumber of words: {onlyWords.Count}\n");
            foreach (var pair in sortedWords)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
        }
    }
}
