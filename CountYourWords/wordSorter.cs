using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
namespace CountYourWords
{
    public class WordSorter
    {
        public List<KeyValuePair<string, int>> SortingAlphabetically(Dictionary<string, int> input)
        {
            var sortedList = new List<KeyValuePair<string,int>>(input);
            for(int i = 0; i < sortedList.Count; i++){
                for(int j = i + 1; j < sortedList.Count; j++){
                    if(string.Compare(sortedList[i].Key, sortedList[j].Key, StringComparison.Ordinal) > 0){
                        var temp = sortedList[i];
                        sortedList[i] = sortedList[j];
                        sortedList[j] = temp;
                    }
                }
            }
            return sortedList;
        }
    }
}
       