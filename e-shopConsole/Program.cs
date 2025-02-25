// See https://aka.ms/new-console-template for more information
using e_shop.DataAccess;
using e_shop.DataAccess.Services;
using e_shop.Domain.Entities;


using var context = new ShopContext();

//var categories = new Category()
//{
//    Id = 1,
//    ParentId = 1,
//    CategoryName = "Smartphone",
//    CategoryDescription = "khgdrabj",
//    Icon = "null",
//    ImagePath = " "

//};

var categoryService = new CategoryService(context);


var product = await categoryService.GetByIdCategory(1);

Console.WriteLine($"{product.Id}: Name:{product.CategoryName} ");

//var productCategory = new ProductCategory()
//{
//    Category = new Category()
//    {
//        Id = 8,
//        ParentId = 8,
//        CategoryName = "Airways",
//        CategoryDescription = " iusfhebiuea",
//        Icon = "fwkejbd",
//        ImagePath = "fkjenb"
//    },

//    Product = new Product()
//    {
//        Id = 1,
//        ProductName = "Boing",
//        SKU = "fewjnjnf",
//        ProductDescription = "fwekjdshj",
//        ShortDescription = "Aziz"

//    }
//};

//context.Add(productCategory);
//context.SaveChanges();




