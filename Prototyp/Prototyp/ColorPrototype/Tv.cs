using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototyp.ColorPrototype
{
    public class Tv : PrototypTv
    { 
        private string producer;
        private float price;
     
        public Tv(string _producer, float _price )
        {
            this.producer = _producer;
            this.price = _price;
        }

        public string Producer
        {
            get => producer;
            set => producer = value;
        }
        public float Cena
        {
            get => price;
            set => price = value;
        }

        public override PrototypTv Clone()
        {
            return this.MemberwiseClone() as Tv;
        }
    }
}
