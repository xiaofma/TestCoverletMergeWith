using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module2;

namespace Test2
{
    [TestClass]
    public class Program
    {
        [TestMethod]
        public void Test1()
        {
            Type2 t1 = new Type2();
            Assert.AreEqual(6, t1.Minus(8, 2));
        }
    }
}
