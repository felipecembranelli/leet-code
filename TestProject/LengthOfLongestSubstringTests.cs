using Xunit;

namespace LeetCode.Tests
{
    public class LengthOfLongestSubstringTests
    {
        [Fact]
        public void Solution_ReturnsCorrectLength()
        {
            // Arrange
            string input = "abcabcbb";
            int expected = 3;

            // Act
            int result = LengthOfLongestSubstring.Solution(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Solution_ReturnsCorrectLengthForEmptyString()
        {
            // Arrange
            string input = "";
            int expected = 0;

            // Act
            int result = LengthOfLongestSubstring.Solution(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Solution_ReturnsCorrectLengthForSingleCharacterString()
        {
            // Arrange
            string input = "a";
            int expected = 1;

            // Act
            int result = LengthOfLongestSubstring.Solution(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Solution_ReturnsCorrectLengthForStringWithAllUniqueCharacters()
        {
            // Arrange
            string input = "abcdef";
            int expected = 6;

            // Act
            int result = LengthOfLongestSubstring.Solution(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Solution_ReturnsCorrectLengthForStringWithAllSameCharacters()
        {
            // Arrange
            string input = "aaaaaa";
            int expected = 1;

            // Act
            int result = LengthOfLongestSubstring.Solution(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Solution_ReturnsCorrectLengthForMixedCharacters()
        {
            // Arrange
            string input = "pwwkew";
            int expected = 3;

            // Act
            int result = LengthOfLongestSubstring.Solution(input);

            // Assert
            Assert.Equal(expected, result);
        }


        [Fact]
        public static void Solution2_ReturnsCorrectLength()
        {
            // Arrange
            string input = "abcabcbb";
            int expected = 3;

            // Act
            int result = LengthOfLongestSubstring.Solution2(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Solution2_ReturnsCorrectLengthForEmptyString()
        {
            // Arrange
            string input = "";
            int expected = 0;

            // Act
            int result = LengthOfLongestSubstring.Solution2(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Solution2_ReturnsCorrectLengthForSingleCharacterString()
        {
            // Arrange
            string input = "a";
            int expected = 1;

            // Act
            int result = LengthOfLongestSubstring.Solution2(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Solution2_ReturnsCorrectLengthForStringWithAllUniqueCharacters()
        {
            // Arrange
            string input = "abcdef";
            int expected = 6;

            // Act
            int result = LengthOfLongestSubstring.Solution2(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Solution2_ReturnsCorrectLengthForStringWithAllSameCharacters()
        {
            // Arrange
            string input = "aaaaaa";
            int expected = 1;

            // Act
            int result = LengthOfLongestSubstring.Solution2(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Solution2_ReturnsCorrectLengthForMixedCharacters()
        {
            // Arrange
            string input = "pwwkew";
            int expected = 3;

            // Act
            int result = LengthOfLongestSubstring.Solution2(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
