using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringHelper.UnitTest
{
    [TestClass]
    public class RepeatTests
    {
        [TestMethod]
        public void TestRepeat_DashTenTimes_ReturnsTenLongDashString()
        {
            var result = "-".Repeat(10);
            Assert.AreEqual("----------", result);
        }
    }
}
