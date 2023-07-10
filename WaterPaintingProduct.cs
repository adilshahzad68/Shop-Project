using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdilShop
{
    public class WaterPaintingProduct : IAssortment
    {
        public string AddProducts(ShoppingCart cart)
        {
            return "WaterPainting added successfully";
        }
        public string RemoveProducts(ShoppingCart cart)
        {
            return "WaterPainting Product removed successfully";
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
