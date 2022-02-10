using System;
using Xunit;
using Magenic.Maqs.BaseTest;

namespace Tests
{
    public class BaseGenericTestXUnit: BaseTest
    {
        [Fact]
        public void SampleTestXUnit()
        {
            this.TestObject.Log.LogMessage("Start Test");
            Assert.True(true, "True is Not True");
        }
    }
}