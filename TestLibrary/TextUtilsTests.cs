using Xunit;
using TextUtils;

namespace TestLibrary
{
    public class TextUtilsGetWordCountShould
    {
        [Fact]
        public void IgnoreCasing()
        {
            var wordCount = WordCount.GetWordCount("Jack", "Jack jack");

            Assert.Equal(2, wordCount);
        }

        [Theory]
        [InlineData(0, "Ting", "Does not appear in the string.")]
        [InlineData(1, "Ting", "Ting appears once.")]
        [InlineData(2, "Ting", "Ting appears twice with Ting.")]
        public void CountInstancesCorrectly(int count,
                                           string searchWord,
                                           string inputString)
        {
            Assert.Equal(count, WordCount.GetWordCount(searchWord,
                                                          inputString));
        }
    }
}