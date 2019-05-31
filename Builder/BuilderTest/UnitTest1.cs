using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Builder.FluentBuilder;
namespace BuilderTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Developer developer = new Developer();
            House home = developer.Construct(new BuilderHouse_A());
            Assert.AreSame("Smallroom", home["room"]);
        }
    }
}
