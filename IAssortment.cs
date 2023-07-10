using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdilShop
{
    public interface IAssortment
    {
        string AddProducts(ShoppingCart cart);
        string RemoveProducts(ShoppingCart cart);
        string AddQuantity(int Quantity);
        IAssortment[] ListProducts();
    }
}
