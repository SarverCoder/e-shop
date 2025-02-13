// See https://aka.ms/new-console-template for more information
using e_shop.DataAccess;
using e_shop.DataAccess.Services;


using var context = new ShopContext();

var GetAllProducts = context.Products;

foreach (var product in GetAllProducts)
{
    Console.WriteLine($"{product.ProductName}");
}    

