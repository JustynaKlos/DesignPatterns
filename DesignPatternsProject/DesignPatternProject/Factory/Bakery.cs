using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternProject.Products.Breads;
using DesignPatternProject.Products.Sweets;


namespace DesignPatternProject.Factory
{
    //metoda wytworcza
    public abstract class Bakery
    {
        protected abstract Bread BakeBread(string bread);
        protected abstract Sweetnesss BakeSweetness(string sweetneess);

        public Bread Bake_Bread(string bread)
        {
            return BakeBread(bread);
        }

        public Sweetnesss Bake_Sweetness(string sweetness)
        {
            return BakeSweetness(sweetness);
        }

    }
}
