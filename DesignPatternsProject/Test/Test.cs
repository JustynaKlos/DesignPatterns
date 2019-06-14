using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Collections.Generic;
using DesignPatternProject.Factory;
using DesignPatternProject.Products.Breads;
using DesignPatternProject.Products.Sweets;
using DesignPatternProject.Adapter;
using DesignPatternProject.Observable;
using DesignPatternProject.State;
namespace Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestSingleton()
        {
            int numberOfParallelLoops = 50;
            Parallel.For(0, numberOfParallelLoops, task =>
            {
                BakeryKlosPodlaski.Create();

            });
            Assert.AreEqual(1, BakeryKlosPodlaski.numberOfObjects);
        }

        [TestMethod]
        public void TestFactory()
        {
            Bakery  bakeryKlosPodlaski = BakeryKlosPodlaski.Create();
            var bakeryPodlaska = bakeryKlosPodlaski.Bake_Sweetness("Muffin");
            Assert.IsNotNull(bakeryPodlaska);
            Bakery bakeryKlosPomorski = BakeryKlosPomorski.Create();
            var bakeryPomorska = bakeryKlosPomorski.Bake_Sweetness("Muffin");
            Assert.AreNotSame(bakeryPodlaska, bakeryPomorska);
        }

        [TestMethod]
        public void TestAdapter()
        {
            Bakery bakeryKlosPodlaski = BakeryKlosPodlaski.Create();
            var MuffinPodlaska = bakeryKlosPodlaski.Bake_Sweetness("Muffin");
            string nameSweetness = MuffinPodlaska.name;
            Product sweetness = new Product(BakeryKlosPodlaski.Create());
            string newNameSweetness = sweetness.change(nameSweetness);
            Assert.AreEqual<string>(newNameSweetness, nameSweetness + "-Podlaski");

            sweetness.changeBakery(BakeryKlosPomorski.Create().logo);
            newNameSweetness = sweetness.change(nameSweetness);
            Assert.AreEqual<string>(newNameSweetness, nameSweetness + "-Pomorski");
        }

        [TestMethod]
        public void TestStateObservable()
        {
           
            Bakery bakeryKlosPodlaski = BakeryKlosPodlaski.Create();
            Sweetnesss muffinPodlaska = bakeryKlosPodlaski.Bake_Sweetness("Muffin");

            Observer worker = new Observer(muffinPodlaska);
            Observer baker = new Observer(muffinPodlaska);
            Observer manager = new Observer(muffinPodlaska);
            List<Observer> observerList = new List<Observer>() { worker, baker, manager };

            CollectionAssert.IsSubsetOf(observerList, muffinPodlaska.observers);

            Assert.IsNull(muffinPodlaska.state);

            manager.update();
            Assert.AreEqual("Production", muffinPodlaska.state.getStatus().GetType().Name);

            manager.update();
            Assert.AreEqual("Baking", muffinPodlaska.state.getStatus().GetType().Name);

            manager.update();
            Assert.AreEqual("Sale", muffinPodlaska.state.getStatus().GetType().Name);
        }
    }
}
