using Functions;

namespace Functions.Tests
{
    public class FunctionServiceTests
    {
        // -------------------------
        // IsValidGrade tests
        // -------------------------
        [Fact]
        public void IsValidGrade_WithValidGrade_ReturnsTrue()
        {
            var service = new FunctionService();
            var result = service.IsValidGrade(3);
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

        // -------------------------
        // HosszabbSzo tests
        // -------------------------
        [Fact]
        public void HosszabbSzo_FirstWordLonger_ReturnsFirstWord()
        {
            var service = new FunctionService();
            var result = service.HosszabbSzo("alma", "fa");
            Assert.Equal("alma", result);
        }

        [Fact]
        public void HosszabbSzo_SecondWordLonger_ReturnsSecondWord()
        {
            var service = new FunctionService();
            var result = service.HosszabbSzo("fa", "korte");
            Assert.Equal("korte", result);
        }

        [Fact]
        public void HosszabbSzo_EqualLength_ReturnsEgyformak()
        {
            var service = new FunctionService();
            var result = service.HosszabbSzo("aa", "bb");
            Assert.Equal("egyformák", result);
        }

        // -------------------------
        // BoltNyitva tests
        // -------------------------
        [Fact]
        public void BoltNyitva_OpenHour_ReturnsTrue()
        {
            var service = new FunctionService();
            var result = service.BoltNyitva(10);
            Assert.True(result);
        }

        [Fact]
        public void BoltNyitva_BeforeOpening_ReturnsFalse()
        {
            var service = new FunctionService();
            var result = service.BoltNyitva(7);
            Assert.False(result);
        }

        [Fact]
        public void BoltNyitva_AfterClosing_ReturnsFalse()
        {
            var service = new FunctionService();
            var result = service.BoltNyitva(17);
            Assert.False(result);
        }

        // -------------------------
        // VanNegativ tests
        // -------------------------
        [Fact]
        public void VanNegativ_WithNegativeNumber_ReturnsTrue()
        {
            var service = new FunctionService();
            var result = service.VanNegativ(new[] { 1, -2, 3 });
            Assert.True(result);
        }

        [Fact]
        public void VanNegativ_WithoutNegativeNumber_ReturnsFalse()
        {
            var service = new FunctionService();
            var result = service.VanNegativ(new[] { 1, 2, 3 });
            Assert.False(result);
        }

        // -------------------------
        // CsereMaganhangzo tests
        // -------------------------
        [Fact]
        public void CsereMaganhangzo_ReplacesVowelsWithDot()
        {
            var service = new FunctionService();
            var result = service.CsereMaganhangzo("alma");
            Assert.Equal(".lm.", result);
        }

        [Fact]
        public void CsereMaganhangzo_NoVowels_ReturnsOriginal()
        {
            var service = new FunctionService();
            var result = service.CsereMaganhangzo("krk");
            Assert.Equal("krk", result);
        }

        // -------------------------
        // TeglalapKerulet tests
        // -------------------------
        [Fact]
        public void TeglalapKerulet_WithValidSides_ReturnsCorrectPerimeter()
        {
            var service = new FunctionService();
            var result = service.TeglalapKerulet(3, 4);
            Assert.Equal(14, result);
        }

        [Fact]
        public void TeglalapKerulet_WithZeroSide_ReturnsCorrectPerimeter()
        {
            var service = new FunctionService();
            var result = service.TeglalapKerulet(0, 5);
            Assert.Equal(10, result);
        }
    }
}
