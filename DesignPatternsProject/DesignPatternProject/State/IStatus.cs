using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using DesignPatternProject.Products;

namespace DesignPatternProject.State
{
    public interface  IStatus
    {
        void changeStatus(IProduct product);
        IStatus getStatus();
    }
}
