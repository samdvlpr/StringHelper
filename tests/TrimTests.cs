using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringHelper.UnitTest
{
    [TestClass]
    public class TrimTests
    {
        private string strlower1 = "hi same world";
        private string str1 = "hI same World";
        private string str2 = "hI different World";

        [TestMethod]
        public void TrimEndToDifference_DifferentCase()
        {
            var (item1, item2) = strlower1.TrimEndToDifference(str2);
            Assert.AreEqual("hi same w", item1);
            Assert.AreEqual("hI different W", item2);
        }

        [TestMethod]
        public void TrimEndToDifference()
        {
            var (item1, item2) = str1.TrimEndToDifference(str2);
            Assert.AreEqual("hI same", item1);
            Assert.AreEqual("hI different", item2);
        }

        [TestMethod]
        public void TrimEndToDifference_IgnoreCase()
        {
            var (item1, item2) = strlower1.TrimEndToDifference(str2, StringComparison.InvariantCultureIgnoreCase);
            Assert.AreEqual("hi same", item1);
            Assert.AreEqual("hI different", item2);
        }

        [TestMethod]
        public void TrimEndToDifference_Same()
        {
            var (item1, item2) = strlower1.TrimEndToDifference(strlower1);
            Assert.AreEqual("", item1);
            Assert.AreEqual("", item2);
        }

        [TestMethod]
        public void TrimEndToDifference_AllDifferent()
        {
            var (item1, item2) = "one".TrimEndToDifference("two");
            Assert.AreEqual("one", item1);
            Assert.AreEqual("two", item2);
        }


        [TestMethod]
        public void TrimStartToDifference_DifferentCase()
        {
            var (item1, item2) = strlower1.TrimStartToDifference(str2);
            Assert.AreEqual("i same world", item1);
            Assert.AreEqual("I different World", item2);
        }

        [TestMethod]
        public void TrimStartToDifference()
        {
            var (item1, item2) = str1.TrimStartToDifference(str2);
            Assert.AreEqual("same World", item1);
            Assert.AreEqual("different World", item2);
        }

        [TestMethod]
        public void TrimStartToDifference_IgnoreCase()
        {
            var (item1, item2) = strlower1.TrimStartToDifference(str2, StringComparison.InvariantCultureIgnoreCase);
            Assert.AreEqual("same world", item1);
            Assert.AreEqual("different World", item2);
        }

        [TestMethod]
        public void TrimStartToDifference_Same()
        {
            var (item1, item2) = strlower1.TrimStartToDifference(strlower1);
            Assert.AreEqual("", item1);
            Assert.AreEqual("", item2);
        }

        [TestMethod]
        public void TrimStartToDifference_AllDifferent()
        {
            var (item1, item2) = "one".TrimStartToDifference("two");
            Assert.AreEqual("one", item1);
            Assert.AreEqual("two", item2);
        }


        [TestMethod]
        public void TrimToDifference_DifferentCase()
        {
            var (item1, item2) = strlower1.TrimToDifference(str2);
            Assert.AreEqual("i same w", item1);
            Assert.AreEqual("I different W", item2);
        }

        [TestMethod]
        public void TrimToDifference()
        {
            var (item1, item2) = str1.TrimToDifference(str2);
            Assert.AreEqual("same", item1);
            Assert.AreEqual("different", item2);
        }

        [TestMethod]
        public void TrimToDifference_IgnoreCase()
        {
            var (item1, item2) = strlower1.TrimToDifference(str2, StringComparison.InvariantCultureIgnoreCase);
            Assert.AreEqual("same", item1);
            Assert.AreEqual("different", item2);
        }

        [TestMethod]
        public void TrimToDifference_Same()
        {
            var (item1, item2) = strlower1.TrimToDifference(strlower1);
            Assert.AreEqual("", item1);
            Assert.AreEqual("", item2);
        }

        [TestMethod]
        public void TrimToDifference_AllDifferent()
        {
            var (item1, item2) = "one".TrimToDifference("two");
            Assert.AreEqual("one", item1);
            Assert.AreEqual("two", item2);
        }
    }
}
