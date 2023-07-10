using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdilShop
{
    public class OilPaintingProduct : IAssortment
    {
        public string AddProducts(ShoppingCart cart)
        {
            return "Oil painting product added successfully";
        }
        public string RemoveProducts(ShoppingCart cart)
        {
            return "Oil painting Product removed successfully";
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
