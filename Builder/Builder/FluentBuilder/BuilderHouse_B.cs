using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentBuilder
{
    public class BuilderHouse_B : BuilderHouse
    {
        public BuilderHouse_B()
        {
            house = new House("A");
        }
        public override BuilderHouse BuildBathroom()
        {
            house["bathroom"] = "BigBathroom";
            return this;
        }
        public override BuilderHouse BuildKitchen()
        {
            house["kitchen"] = "BigBathroom";
            return this;
        }
        public override BuilderHouse BuildCorridor()
        {
            house["corridor"] = "BigCorridor";
            return this;
        }
        public override BuilderHouse BuildRoom()
        {
            house["room"] = "Bigoom";
            return this;
        }
    }
}
