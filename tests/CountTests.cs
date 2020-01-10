using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringHelper.UnitTest
{
    [TestClass]
    public class CountTests
    {
        private string strlower1 = "hi same world";
        private string str1 = "hi same World";
        private string str2 = "hi different World";

        [TestMethod]
        public void CountEndToDifference_DifferentCase()
        {
            var result = strlower1.CountEndToDifference(str2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void CountEndToDifference()
        {
            var result = str1.CountEndToDifference(str2);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void CountEndToDifference_IgnoreCase()
        {
            var result = strlower1.CountEndToDifference(str2, StringComparison.InvariantCultureIgnoreCase);
            Assert.AreEqual(6, result);
        }
    }
}
