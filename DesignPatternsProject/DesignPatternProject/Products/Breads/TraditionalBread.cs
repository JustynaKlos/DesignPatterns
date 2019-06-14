using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.Products.Breads
{
    public class TraditionalBread : Bread
    {
        public TraditionalBread()
        {
            name = "Traditional Bread";
            price = 7.99f;
        }
    }
}
