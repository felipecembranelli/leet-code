

namespace LeetCode.Tests
{
    public class BubbleSortTests
    {
        [Fact]
        public void BubbleSort_SortsArrayCorrectly()
        {
            // Arrange
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            int[] expected = { 11, 12, 22, 25, 34, 64, 90 };

            // Act
            BubbleSort.bubbleSort(arr, arr.Length);

            // Assert
            Assert.Equal(expected, arr);
        }

        [Fact]
        public void BubbleSort_EmptyArray()
        {
            // Arrange
            int[] arr = { };
            int[] expected = { };

            // Act
            BubbleSort.bubbleSort(arr, arr.Length);

            // Assert
            Assert.Equal(expected, arr);
        }

        [Fact]
        public void BubbleSort_SingleElementArray()
        {
            // Arrange
            int[] arr = { 1 };
            int[] expected = { 1 };

            // Act
            BubbleSort.bubbleSort(arr, arr.Length);

            // Assert
            Assert.Equal(expected, arr);
        }

        [Fact]
        public void BubbleSort_AlreadySortedArray()
        {
            // Arrange
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            BubbleSort.bubbleSort(arr, arr.Length);

            // Assert
            Assert.Equal(expected, arr);
        }

        [Fact]
        public void BubbleSort_ReverseSortedArray()
        {
            // Arrange
            int[] arr = { 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            BubbleSort.bubbleSort(arr, arr.Length);

            // Assert
           Assert.Equal(expected, arr);
        }
    }
}
