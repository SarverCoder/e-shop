// See https://aka.ms/new-console-template for more information
using e_shop.DataAccess;
using e_shop.DataAccess.Services;

Console.WriteLine("Hello, World!");

using var context = new ShopContext();

var service = new ProductService(context);

