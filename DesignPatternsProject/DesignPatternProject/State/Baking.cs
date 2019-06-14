using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternProject.Products;
using DesignPatternProject.State;

namespace DesignPatternProject.State
{
    public class Baking : IStatus
    {
        public void changeStatus(IProduct product)
        {
            product.state = this;
        }
        public IStatus getStatus()
        {
            return this;
        }
    }
}
