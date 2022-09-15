using System;
using System.Linq;

namespace TextUtils;

public static class WordCount
{
    public static int GetWordCount(string searchWord, string inputString)
    {
        // Null check these variables and determine if they have values.
        if (string.IsNullOrEmpty(searchWord) || string.IsNullOrEmpty(inputString))
        {
            return 0;
        }

        // Convert the string into an array of words.
        string[] source = inputString.Split(new[]
            {
                '.', '?', '!', ' ', ';', ':', ','
            },
            StringSplitOptions.RemoveEmptyEntries);

        // Create the query. Use ToLowerInvariant to match uppercase/lowercase strings.
        var matchQuery = from word in source
            where string.Equals(word, searchWord, StringComparison.InvariantCultureIgnoreCase)
            select word;

        // Count the matches, which executes the query. Return the result.
        return matchQuery.Count();
    }
}
