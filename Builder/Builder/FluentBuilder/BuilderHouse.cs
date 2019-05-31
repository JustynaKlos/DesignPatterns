using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentBuilder
{
    public abstract class BuilderHouse
    {
        protected House house;

        public House GetHouse() { return house; } 

        public abstract BuilderHouse BuildRoom();
        public abstract BuilderHouse BuildBathroom();
        public abstract BuilderHouse BuildKitchen();
        public abstract BuilderHouse BuildCorridor();
       
        public static implicit operator House(BuilderHouse houseBuilder)
        {
            return houseBuilder
                .BuildRoom()
                .BuildBathroom()
                .BuildKitchen()
                .BuildCorridor()
                .house;
        }
    }
}
