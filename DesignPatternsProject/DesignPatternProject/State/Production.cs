using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternProject.Products;
using DesignPatternProject.State;

namespace DesignPatternProject.State
{
    public class Production : IStatus
    {
        public void changeStatus(IProduct product)
        {
            //przekazanie obiektu jako parametru
            product.state = this;
        }
        public IStatus getStatus()
        {
            return this;
        }
    }
}
