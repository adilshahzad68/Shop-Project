
using AdilShop;

var product = ShoppingCartFactory.GetProduct("PencilSketch");
if (product != null)
{
    ShoppingCart cart = new ShoppingCart();
    cart.Assortment = product;
    cart.Net = "1";
    cart.Tax = 0.10;
    cart.GrossPrice = 10.00;
    cart.NumberOfPieces = 1;

    Console.WriteLine("Products addition to the cart: " + product.AddProducts(cart));
    Console.WriteLine("Products removal from cart : " + product.RemoveProducts(cart));
    Console.WriteLine("Products quantity has been increased :" + product.AddQuantity(3));
    Console.WriteLine("Products List :" + product.ListProducts());
}
else
{
    Console.Write("Invalid product type");
}
Console.ReadLine();