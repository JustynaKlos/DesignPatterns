using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prototyp.ColorPrototype;
using Prototyp;
namespace TestPrototyp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCopyColorPrototype()
        {
            Tv tv_A = new Tv("Samsung", 4000);
            Tv tv_B = tv_A.Clone() as Tv;
            tv_B.Producer = "Lg";
            Assert.AreNotSame(tv_A.Producer, tv_B.Producer);
        }
    }
}
