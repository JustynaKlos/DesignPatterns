using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentBuilder
{
    public class BuilderHouse_A : BuilderHouse
    {
        public BuilderHouse_A()
        {
            house = new House("A");
        }
        public override BuilderHouse BuildBathroom()
        {
            house["bathroom"] = "SmallBathroom";
            return this;
        }
        public override BuilderHouse BuildKitchen()
        {
            house["kitchen"] = "SmallBathroom";
            return this;
        }
        public override BuilderHouse BuildCorridor()
        {
            house["corridor"] = "SmallCorridor";
            return this;
        }
        public override BuilderHouse BuildRoom()
        {
            house["room"] = "Smallroom";
            return this;
        }
    }
}
