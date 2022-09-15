using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextUtils;

namespace TestLibrary;

[TestClass]
public class TextUtilsGetWordCountShould
{
    [TestMethod]
    [DataRow(0, "Ting", "Does not appear in the string.")]
    [DataRow(1, "Ting", "Ting appears once.")]
    [DataRow(2, "Ting", "Ting appears twice with Ting.")]
    public void CountInstancesCorrectly(
        int count,
        string searchWord,
        string inputString)
    {
        Assert.AreEqual(count, WordCount.GetWordCount(searchWord,
            inputString));
    }
    [TestMethod]
    public void IgnoreCasing()
    {
        int wordCount = WordCount.GetWordCount("Jack", "Jack jack");
        Assert.AreEqual(2, wordCount);
    }
    [TestMethod]
    [DataRow(0, null, null)]
    [DataRow(0, "string", null)]
    [DataRow(0, null, "string")]
    public void Test_WordCount_NullsProvided(
        int expected,
        string searchWord,
        string inputString)
    {
        Assert.AreEqual(expected, WordCount.GetWordCount(searchWord, inputString));
    }
}
