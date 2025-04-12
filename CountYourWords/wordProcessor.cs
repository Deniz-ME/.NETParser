using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("CountYourWordsTests")] // In this way only the test File is able to see the "private" functions.

namespace CountYourWords
{
    public class WordProcessor
    {
        public List<string> CleanText(string input)
        {
            var lowercasedInput = ToLowercase(input);
            var nonAlphabeticCharsRemoved = RemoveNonAlphabeticChar(lowercasedInput);
            var splittedIntoList = SplitStringIntoList(nonAlphabeticCharsRemoved);
            var fullyProcessedList = RemoveEmptyWordsAndSpaces(splittedIntoList);
            return fullyProcessedList;
        }

        internal string ToLowercase(string input) 
        {
            return input.ToLower();
        }
        internal string RemoveNonAlphabeticChar(string input) 
        {
            var result = Regex.Replace(input,@"[^a-zA-Z\s]", "");
            return result;
        }
        internal List<string> SplitStringIntoList(string input) 
        {
            var listWords = new List<string>(input.Split(" " , StringSplitOptions.RemoveEmptyEntries));
            return listWords;
        }
        internal List<string> RemoveEmptyWordsAndSpaces(List<string> input) 
        {
            var finalList = new List<string>();
            foreach(var word in input){
                if(!string.IsNullOrWhiteSpace(word)){
                    finalList.Add(word);
                }
            }
            return finalList;
        }
    }
}