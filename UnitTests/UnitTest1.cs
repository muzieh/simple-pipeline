using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
                Assert.True(true);
        }

        [Fact]
        public void FailingTest()
        {
            Assert.False(false, "oj");
        }

        [Fact]
        public void OneMoreTest()
        {
            Assert.True(true);
        }
    }
}