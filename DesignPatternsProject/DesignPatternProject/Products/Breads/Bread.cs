using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternProject.State;
using DesignPatternProject.Products;
using DesignPatternProject.Observable;

namespace DesignPatternProject.Products.Breads
{
    public class Bread : IProduct
    {
        public string name { get; set; }
        public float price { get; set; }
        public IStatus state { get; set; }
        public List<Observer> observers { get; set; }
        public Bread()
        {
            observers = new List<Observer>();
        }
        public void addObserver(Observer observer)
        {
            observers.Add(observer);
        }
    }
}
