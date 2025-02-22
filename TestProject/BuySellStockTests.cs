using Xunit;

namespace LeetCode.Tests
{
    public class BuySellStockTests
    {
        [Fact]
        public void Calculate_ReturnsCorrectProfit()
        {
            // Arrange
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int expected = 5;

            // Act
            int result = BuySellStock.Calculate(prices);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate_NoProfit()
        {
            // Arrange
            int[] prices = { 7, 6, 4, 3, 1 };
            int expected = 0;

            // Act
            int result = BuySellStock.Calculate(prices);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate_SingleDay()
        {
            // Arrange
            int[] prices = { 5 };
            int expected = 0;

            // Act
            int result = BuySellStock.Calculate(prices);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate2_ReturnsCorrectProfit()
        {
            // Arrange
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int expected = 5;

            // Act
            int result = BuySellStock.Calculate2(prices);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate2_NoProfit()
        {
            // Arrange
            int[] prices = { 7, 6, 4, 3, 1 };
            int expected = 0;

            // Act
            int result = BuySellStock.Calculate2(prices);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate2_SingleDay()
        {
            // Arrange
            int[] prices = { 5 };
            int expected = 0;

            // Act
            int result = BuySellStock.Calculate2(prices);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate3_ReturnsCorrectProfit()
        {
            // Arrange
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int expected = 5;

            // Act
            int result = BuySellStock.Calculate2(prices);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate3_NoProfit()
        {
            // Arrange
            int[] prices = { 7, 6, 4, 3, 1 };
            int expected = 0;

            // Act
            int result = BuySellStock.Calculate3(prices);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate3_SingleDay()
        {
            // Arrange
            int[] prices = { 5 };
            int expected = 0;

            // Act
            int result = BuySellStock.Calculate3(prices);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
