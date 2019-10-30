using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringHelper.UnitTest
{
    [TestClass]
    public class WrapTests
    {
        [TestMethod]
        public void TestWrap_OnTenCharWordWithWarpLengthFive_ReturnsTwoFiveCharStrings()
        {
            var results = "whizzbangs".Wrap(5);

            //CollectionAssert.AreEqual(new [] { "whizz", "bangs" } , results.ToArray());

            Assert.AreEqual(2, results.Count());

            Assert.AreEqual("whizz", results.ToArray()[0]);

            Assert.AreEqual("bangs", results.ToArray()[1]);
        }
    }
}
