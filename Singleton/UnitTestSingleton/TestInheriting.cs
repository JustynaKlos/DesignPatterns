using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton1;

namespace UnitTestSingleton
{
    [TestClass]
    public class TestInheriting
    {
        [TestMethod]
        public void Test1()
        {
            var child1 = SingletonChild1.Create();
            var child2 = SingletonChild2.Create();
            Assert.AreNotSame(child1, child2);
        }

        [TestMethod]
        public void Test2()
        {
            var grandson1A = Grandson1A.Create();
            var grandson1B = Grandson1B.Create();
            Assert.AreSame(grandson1A, grandson1B);
        }

        [TestMethod]
        public void Test3()
        {
            var child1 = SingletonChild1.Create();
            var grandson1B = Grandson1B.Create();
            Assert.AreSame(child1, grandson1B);
        }
    }
}
