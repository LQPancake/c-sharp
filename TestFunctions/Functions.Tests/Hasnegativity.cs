using Functions;

namespace Functions.Tests
{
    public class HasnegativityTest
    {
        [Fact]
        public void HasNegativity_ReturnsTrue()
        {
            // Arrange
            var service = new FunctionService();
            var result = true;


            // Act
            Assert.True(service.HasNegativity([-1,25,-6,1000]));
            Assert.True(service.HasNegativity([-1, -25, -6, -1000,3]));
            Assert.True(service.HasNegativity([-1, -25, -6, -1000, 3,8,-1]));


            // Assert
            Assert.True(result);
        }

        [Fact]
        public void HasNegativity_ReturnsFalse()
        {
            var service = new FunctionService();
            Assert.True(service.HasNegativity([1, 25, 6, 1000]));
            Assert.True(service.HasNegativity([157, 25, 643, 1000]));
            Assert.True(service.HasNegativity([31, 255, 67, 1000]));
            Assert.True(service.HasNegativity([31, 255, 67, 1000,0]));
            Assert.True(service.HasNegativity([]));

        }

    }
}