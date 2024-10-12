using Xunit;

namespace LeetCode.Tests
{
    public class QuicksortTests
    {
        [Fact]
        public void Quicksort_SortsArrayCorrectly()
        {
            // Arrange
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            int[] expected = { 11, 12, 22, 25, 34, 64, 90 };

            // Act
            Quicksort(arr, 0, arr.Length - 1);

            // Assert
            Assert.Equal(expected, arr);
        }

        [Fact]
        public void Quicksort_EmptyArray()
        {
            // Arrange
            int[] arr = { };
            int[] expected = { };

            // Act
            Quicksort(arr, 0, arr.Length - 1);

            // Assert
            Assert.Equal(expected, arr);
        }

        [Fact]
        public void Quicksort_SingleElementArray()
        {
            // Arrange
            int[] arr = { 1 };
            int[] expected = { 1 };

            // Act
            Quicksort(arr, 0, arr.Length - 1);

            // Assert
            Assert.Equal(expected, arr);
        }

        [Fact]
        public void Quicksort_AlreadySortedArray()
        {
            // Arrange
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            Quicksort(arr, 0, arr.Length - 1);

            // Assert
            Assert.Equal(expected, arr);
        }

        [Fact]
        public void Quicksort_ReverseSortedArray()
        {
            // Arrange
            int[] arr = { 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            Quicksort(arr, 0, arr.Length - 1);

            // Assert
            Assert.Equal(expected, arr);
        }

        // Assuming the Quicksort method is defined as follows:
        public void Quicksort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                Quicksort(arr, low, pi - 1);
                Quicksort(arr, pi + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
    }
}
