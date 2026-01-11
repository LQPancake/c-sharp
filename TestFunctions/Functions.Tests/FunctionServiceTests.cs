using Functions;

namespace Functions.Tests
{
    public class FunctionServiceTests
    {
        [Fact]
        public void IsValidGrade_WithValidGrade_ReturnsTrue()
        {
            // Arrange
            var service = new FunctionService();

            // Act
            var result = service.IsValidGrade(3);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidGrade_WithGradeZero_ReturnsFalse()
        {
            var service = new FunctionService();
            var result = service.IsValidGrade(0);

            Assert.False(result);
        }

        [Fact]
        public void IsValidGrade_WithGradeAboveFive_ReturnsFalse()
        {
            var service = new FunctionService();
            var result = service.IsValidGrade(6);

            Assert.False(result);
        }
    }
}