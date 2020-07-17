using System;
using Xunit;

namespace SubtractionProject.Tests
{
    public class SubtractClassUnitTests
    {
        [Fact]
        public void PositiveInputNegativeResult()
        {
            Assert.Equal(SubtractClass.Subtract(1, 2), -1);
        }

        [Fact]
        public void PositiveInputPositveResult()
        {
            Assert.Equal(SubtractClass.Subtract(10, 3), 7);
        }

        [Fact]
        public void NegativeInputNegativeResult()
        {
            Assert.Equal(SubtractClass.Subtract(-18, -11), -7);
        }

        [Fact]
        public void NegativeInputPositiveResult()
        {
            Assert.Equal(SubtractClass.Subtract(-10, -30), 20);
        }

        [Fact]
        public void NegativeSubtractionOverLimitTwoNumbersNearLimit()
        {
            Assert.Throws<OverflowException>(() => SubtractClass.Subtract(2147483647, -2147483647));
        }

        [Fact]
        public void PositiveSubtractionOverLimitTwoNumbersNearLimit()
        {
            Assert.Throws<OverflowException>(() => SubtractClass.Subtract(-2147483647, 2147483647));
        }

        [Fact]
        public void PositiveSubtractionOverLimitOneNumberNearLimit()
        {
            Assert.Throws<OverflowException>(() => SubtractClass.Subtract(-2147483647, 20));
        }
    }
}
