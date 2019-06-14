using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternProject.Products;
using DesignPatternProject.State;
using DesignPatternProject.Observable;

namespace DesignPatternProject.Products.Sweets
{
    public class Sweetnesss : IProduct
    {
        public string name { get; set; }
        public float price { get; set; }
        public IStatus state { get; set; }
        public List<Observer> observers { get; set; }
        public Sweetnesss()
        {
            observers = new List<Observer>();
        }
        public void addObserver(Observer observer)
        {
            observers.Add(observer);
        }
    }
}
