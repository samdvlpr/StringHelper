using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringHelper.UnitTest
{
    [TestClass]

    public class RandomStringTest
    {
        [TestMethod]

        public void RandomTest()
        {
            List<string> randoms = new List<string>();
            for (int f = 0; f < 1000; f++)
            {
                string rand = new RandomString();
                randoms.Add(rand);
            }
            Assert.IsTrue(randoms.Count == randoms.Distinct().Count());
        }
    }
}
