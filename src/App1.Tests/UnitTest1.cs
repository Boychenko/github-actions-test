using System;
using Xunit;

namespace App1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(0, new Random().Next(5, 100));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(0, 0);
        }
    }
}
