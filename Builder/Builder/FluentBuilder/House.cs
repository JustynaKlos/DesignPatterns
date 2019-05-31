using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentBuilder
{
    public class House
    {
        private string houseType;
        private Dictionary<string, string> rooms = new Dictionary<string, string>();

        public House(string house)
        {
            this.houseType = house;
        }

        public string this[string key]
        {
            get { return rooms[key]; }
            set { rooms[key] = value; }
        }
    }
}
