using TextUtils;

namespace WordCounterApp;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Enter a search word:");
        string? searchWord = Console.ReadLine();
        Console.WriteLine("Provide a string to search:");
        string? inputString = Console.ReadLine();
        int wordCount = WordCount.GetWordCount(searchWord, inputString);
        var pluralChar = "s";
        if (wordCount == 1)
        {
            pluralChar = string.Empty;
        }
        Console.WriteLine($"The search word {searchWord} appears " +
                          $"{wordCount} time{pluralChar}.");
    }
}
