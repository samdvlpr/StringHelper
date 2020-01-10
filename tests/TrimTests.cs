using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringHelper.UnitTest
{
    [TestClass]
    public class TrimTests
    {
        private string strlower1 = "hi same world";
        private string str1 = "hi same World";
        private string str2 = "hi different World";

        [TestMethod]
        public void TrimEndToDifference_DifferentCase()
        {
            var (item1, item2) = strlower1.TrimEndToDifference(str2);
            Assert.AreEqual("hi same w", item1);
            Assert.AreEqual("hi different W", item2);
        }

        [TestMethod]
        public void TrimEndToDifference()
        {
            var (item1, item2) = str1.TrimEndToDifference(str2);
            Assert.AreEqual("hi same", item1);
            Assert.AreEqual("hi different", item2);
        }

        [TestMethod]
        public void TrimEndToDifference_IgnoreCase()
        {
            var (item1, item2) = strlower1.TrimEndToDifference(str2, StringComparison.InvariantCultureIgnoreCase);
            Assert.AreEqual("hi same", item1);
            Assert.AreEqual("hi different", item2);
        }
    }
}
