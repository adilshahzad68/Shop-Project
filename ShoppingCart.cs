using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdilShop
{
    public class ShoppingCart
    {
        public IAssortment Assortment { get; set; }
        public int NumberOfPieces { get; set; }
        public string Net { get; set; }
        public double Tax { get; set; }
        public double GrossPrice { get; set; }

    }
    class ShoppingCartFactory
    {
        public static IAssortment GetProduct(string productType)
        {
            IAssortment productDetails = null;
            if (productType == "OilPainting")
            {
                productDetails = new OilPaintingProduct();
            }
            else if (productType == "WaterPainting")
            {
                productDetails = new WaterPaintingProduct();
            }
            else if (productType == "PencilSketch")
            {
                productDetails = new PencilSketchProduct();
            }
            else if (productType == "AbstractArt")
            {
                productDetails = new AbstractArtProduct();
            }
            return productDetails;
        }
    }
}
