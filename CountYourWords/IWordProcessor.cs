using System.Collections.Generic;

namespace CountYourWords
{
    public interface IWordProcessor
    {
        List<string> CleanText(string input);
    }
}