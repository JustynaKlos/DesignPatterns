using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton1;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace UnitTestSingleton
{
    [TestClass]
    public class TestMultithreading
    {
        [TestMethod]
        public void Test1()
        {
            int numberOfParallerLoops = 50;
            Parallel.For(0, numberOfParallerLoops, task =>
            {  
               SingletonChild1.Create();
                
            });
            Assert.AreEqual(1, SingletonChild1.numberOfObject);
        }

    }
}
