using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSquareLibrary;
using Xunit;

namespace xUnitTest
{
    public class UnitTestTriangle
    {
        [Fact]
        public void TriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.Equal(triangle.Square(), 6);
        }
    }
}
