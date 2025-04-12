using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
namespace CountYourWords
{
    public class WordCounter
    {
        public Dictionary<string, int> CountWords(List<string> input)
        {
            var countDict = WordsDictionary(input);
            return countDict;
        }

        private Dictionary<string, int> WordsDictionary(List<string> words)
        {
            var countDictionary = new Dictionary<string, int>();

            foreach(var word in words){
                if(countDictionary.ContainsKey(word)) countDictionary[word]++;
                else countDictionary[word] = 1;    
            }
            return countDictionary;
        }
    }
}