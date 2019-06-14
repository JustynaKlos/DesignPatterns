using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternProject.State;
using DesignPatternProject.Observable;

namespace DesignPatternProject.Products
{
    public interface IProduct
    {
        string name { get; set; }
        float price { get; set; }
        IStatus state { get; set; }
        List<Observer> observers { get; set; }
        void addObserver(Observer observer);
    }
}
