using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module1;
using System;

namespace Test1
{
    [TestClass]
    public class Program
    {
        [TestMethod]
        public void Test1()
        {
            Type1 t1 = new Type1();
            Assert.AreEqual(10, t1.Add(2, 8));
        }
    }
}
