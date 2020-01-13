using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringHelper.UnitTest
{
    [TestClass]
    public class CountTests
    {
        private string strlower1 = "hi same world";
        private string str1 = "hI same World";
        private string str2 = "hI different World";

        [TestMethod]
        public void CountEndToDifference_LeftEmpty()
        {
            var result = "".CountEndToDifference("one");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CountEndToDifference_RightEmpty()
        {
            var result = "one".CountEndToDifference("");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CountEndToDifference_BothEmpty()
        {
            var result = "".CountEndToDifference("1");
            Assert.AreEqual(0, result);
        }

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


        [TestMethod]
        public void CountStartToDifference_DifferentCase()
        {
            var result = strlower1.CountStartToDifference(str2);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CountStartToDifference()
        {
            var result = str1.CountStartToDifference(str2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CountStartToDifference_IgnoreCase()
        {
            var result = strlower1.CountStartToDifference(str2, StringComparison.InvariantCultureIgnoreCase);
            Assert.AreEqual(3, result);
        }
    }
}
