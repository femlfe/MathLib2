using MathLib;

namespace MathLibTests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckSumResult()
        {
            // Arrange
            Culculation culculation = new Culculation();

            // Act
            var result = culculation.Sum(2, 3);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void CheckFactorialResult()
        {
            // Arrange
            Culculation culculation = new Culculation();

            // Act
            var result = culculation.Factorial(4);

            // Assert
            Assert.Equal(24 ,result);
        }
    }
}