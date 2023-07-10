using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdilShop
{
    public class PencilSketchProduct :IAssortment
    {
        public string AddProducts(ShoppingCart cart)
        {
            return "PencilSketch Product added successfully";
        }
        public string RemoveProducts(ShoppingCart cart)
        {
            return "PencilSketch Product removed successfully";
        }
        public string AddQuantity(int Quantity)
        {
            return "Quantity added";
        }
        public IAssortment[] ListProducts()
        {
            return new IAssortment[4];
        }
    }
}
