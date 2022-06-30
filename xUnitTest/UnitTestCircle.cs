using System;
using TestSquareLibrary;
using Xunit;

namespace xUnitTest
{
    public class UnitTestCircle
    {
        [Fact]
        public void TestCircle()
        {
            var circle = new Circle(32);
            Assert.Equal(circle.Square(), 3216.990877275948);
        }
    }
}
