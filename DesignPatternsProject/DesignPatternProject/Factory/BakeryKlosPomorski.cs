using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternProject.Products.Breads;
using DesignPatternProject.Products.Sweets;

namespace DesignPatternProject.Factory
{
    public class BakeryKlosPomorski : Bakery
    {
        private static BakeryKlosPomorski @object;
        private static readonly object @lock = new object();
        public static int numberOfObjects = 0;
        protected BakeryKlosPomorski() { }

        public static BakeryKlosPomorski Create()
        {
            if (@object == null)
            {
                lock (@lock)
                {
                    if (@object == null)
                    {
                        @object = new BakeryKlosPomorski();
                        numberOfObjects++;
                    }
                }
            }
            return @object;
        }

        protected override Bread BakeBread(string bread)
        {
            switch (bread)
            {
                case "MultigrainBread":
                    return new MultigrainBread() as Bread;
                case "TraditionalBread":
                    return new TraditionalBread() as Bread;
                default:
                    return null;
            }

        }
        protected override Sweetnesss BakeSweetness(string sweetneess)
        {
            switch (sweetneess)
            {
                case "Muffin":
                    return new Muffin() as Sweetnesss;
                case "StrawberryPie":
                    return new StrawberryPie() as Sweetnesss;
                default:
                    return null;
            }
        }
        public string logo(string logo)
        {
            return logo + "-Pomorski";
        }
    }
}
