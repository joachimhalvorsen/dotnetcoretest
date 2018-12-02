using Xunit;
using System.Collections.Generic;
using System;

namespace TestApiUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            var a = new List<string>();
            Assert.Equal(4, (int) Math.Round(4.0));
        }

        [Fact]
        public void Failingest()
        {
            Assert.Equal(4, 5);
        }
    }
}
