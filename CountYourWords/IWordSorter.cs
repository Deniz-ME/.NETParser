using System.Collections.Generic;

namespace CountYourWords
{
    public interface IWordSorter
    {
        List<KeyValuePair<string, int>> SortingAlphabetically(Dictionary<string, int> input);
    }
}