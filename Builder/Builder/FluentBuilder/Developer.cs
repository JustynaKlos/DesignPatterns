using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentBuilder
{
    public class Developer
    {
        public House Construct(BuilderHouse houseBuilder)
        {
            return houseBuilder;
        }
    }
}
