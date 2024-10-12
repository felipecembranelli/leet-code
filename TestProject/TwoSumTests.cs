using Xunit;

namespace LeetCode.Tests
{
    public class TwoSumTests
    {
        [Fact]
        public void CalculateBrutalForce_FindsCorrectIndices()
        {
            // Arrange
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            string expected = "[0,1]";

            // Act
            string result = TwoSum.CalculateBrutalForce(nums, target);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateBrutalForce_NoSolution()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4 };
            int target = 8;
            string expected = "[-1,-1]";

            // Act
            string result = TwoSum.CalculateBrutalForce(nums, target);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateBrutalForce_SingleElementArray()
        {
            // Arrange
            int[] nums = { 1 };
            int target = 1;
            string expected = "[-1,-1]";

            // Act
            string result = TwoSum.CalculateBrutalForce(nums, target);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateBrutalForce_EmptyArray()
        {
            // Arrange
            int[] nums = { };
            int target = 0;
            string expected = "[-1,-1]";

            // Act
            string result = TwoSum.CalculateBrutalForce(nums, target);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateBrutalForce_MultiplePairs()
        {
            // Arrange
            int[] nums = { 1, 3, 2, 4 };
            int target = 5;
            string expected = "[0,3]"; // The first pair that sums to 5 is (1, 4)

            // Act
            string result = TwoSum.CalculateBrutalForce(nums, target);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateBrutalForce_SinglePairs2()
        {
            // Arrange
            int[] nums = { 3, 2, 4 };
            int target = 6;
            string expected = "[1,2]"; 

            // Act
            string result = TwoSum.CalculateBrutalForce(nums, target);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
