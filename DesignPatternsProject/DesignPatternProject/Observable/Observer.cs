using DesignPatternProject.Products;
using DesignPatternProject.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.Observable
{
    public class Observer
    {
        private IProduct product;
        public Observer(IProduct product)
        {
            this.product = product;
            this.product.addObserver(this);
        }
        public void update()
        {
            if (product.state == null) {
               // Production of cake
                new Production().changeStatus(product);
                return;
            }

            Type baking = new Baking().GetType();

            switch (product.state.getStatus().GetType().Name) {
                case "Production":
                 // Baking of bake
                    new Baking().changeStatus(product);
                    break;
                case "Baking":
                  // Ready for sale
                    new Sale().changeStatus(product);
                    break;
                case "Sale":
                    // Is waiting for the customer
                    break;
            }
        }
    }
}
