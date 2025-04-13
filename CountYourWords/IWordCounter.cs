using System.Collections.Generic;

namespace CountYourWords
{
    public interface IWordCounter
    {
         Dictionary<string, int> CountWords(List<string> input);
    }
}