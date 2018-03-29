namespace tdd_implementation
{
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordFrequencyNumberProcessor
    {
        public string caculate(string inputStr)
        {
            if (inputStr.Equals(string.Empty))
            {
                return string.Empty;
            }

            var strList = inputStr.Split(' ').ToList();
            var wordList = strList.Select(str => new { Str = str, Count = 1 })
                .GroupBy(word => word.Str)
                .Select(newWord => new { Str = newWord.Key, Count = newWord.Sum(x => x.Count) })
                .ToList();

            wordList = wordList.OrderByDescending(word => word.Count).ToList();
            var resultList = wordList.Select(word => word.Str + " " + word.Count).ToList();

            return string.Join("\r\n", resultList);

        }
    }
}
