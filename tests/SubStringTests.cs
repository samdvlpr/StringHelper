using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringHelper.UnitTest
{
    [TestClass]
    public class SubStringTests
    {
        private string strlower1 = "hi same world";
        private string str1 = "hI same World";
        private string str2 = "hI different World";

        [TestMethod]
        public void SubStringEndToDifference_DifferentCase()
        {
            var result = strlower1.SubStringEndToDifference(str2);
            Assert.AreEqual("orld", result);
        }

        [TestMethod]
        public void SubStringEndToDifference()
        {
            var result = str1.SubStringEndToDifference(str2);
            Assert.AreEqual(" World", result);
        }

        [TestMethod]
        public void SubStringEndToDifference_IgnoreCase()
        {
            var result = strlower1.SubStringEndToDifference(str2, StringComparison.InvariantCultureIgnoreCase);
            Assert.AreEqual(" world", result);
        }


        [TestMethod]
        public void SubStringStartToDifference_DifferentCase()
        {
            var result = strlower1.SubStringStartToDifference(str2);
            Assert.AreEqual("h", result);
        }

        [TestMethod]
        public void SubStringStartToDifference()
        {
            var result = str1.SubStringStartToDifference(str2);
            Assert.AreEqual("hI ", result);
        }

        [TestMethod]
        public void SubStringStartToDifference_IgnoreCase()
        {
            var result = strlower1.SubStringStartToDifference(str2, StringComparison.InvariantCultureIgnoreCase);
            Assert.AreEqual("hi ", result);
        }
    }
}
