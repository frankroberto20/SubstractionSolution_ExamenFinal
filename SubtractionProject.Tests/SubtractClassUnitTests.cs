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

    }
}
