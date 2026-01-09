using Functions;

namespace Functions.Tests
{
    public class IsopenTest
    {
        [Fact]
        public void FirstWordLonger_ReturnFirstWord()
        {
            // Arrange
            var service = new FunctionService();

            // Act
            var result = service.GetLongerWord("Gesztenye","Dió");

            // Assert
            Assert.Equal("Gesztenye", result);
        }
        [Fact]
        public void SecondWordLonger_ReturnSecondWord()
        {
            // Arrange
            var service = new FunctionService();

            // Act
            var result = service.GetLongerWord("Borsó", "Zöldbab");

            // Assert
            Assert.Equal("Zöldbab", result);
        }

        [Fact]
        public void EqualLengthWords_ReturnEgyformak()
        {
            // Arrange
            var service = new FunctionService();

            // Act
            var result = service.GetLongerWord("Karfiol", "Zöldbab");

            // Assert
            Assert.Equal("Egyformák", result);
        }

    }
}