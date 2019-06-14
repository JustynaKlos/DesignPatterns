using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternProject.Factory;

namespace DesignPatternProject.Adapter
{
    public class Product
    {
        public Func<string, string> change;
       
        public Product(BakeryKlosPodlaski changeBakery)
        {
            change = changeBakery.logo;
        }
        public Product(BakeryKlosPomorski changeBakery)
        {
            change = changeBakery.logo;
        }
        public void changeBakery(Func<string, string> func)
        {
            change = func;
        }
    }
}
