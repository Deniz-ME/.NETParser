using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("CountYourWordsTests")] //In this way only the test File is able to see the "private" functions.

namespace CountYourWords
{
    public class WordProcessor
    {
        public List<string> CleanText(string input)
        {
            var lowercasedInput = ToLowercase(input);
            var result = new List<string> {};
            return result;
        }

        internal string ToLowercase(string input) 
        {
            return input.ToLower();
        }
        internal string RemoveNonAlphabeticChar(string input) 
        {
            return "";
        }
        internal List<string> SplitStringIntoList(string input) 
        {
            var result = new List<string> {};
            return result;
        }
        internal List<string> RemoveEmptyWordsAndSpaces(List<string> input) 
        {
            var result = new List<string> {};
            return result;
        }
    }
}