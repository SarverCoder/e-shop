using e_shop.DataAccess;
using e_shop.Domain.Entities;
using e_shop.WebApi.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_shop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext context;

        public ProductsController(ShopContext _context)
        {
            context = _context;
        }

        [HttpGet("all-products")]
        public IActionResult GetAllProducts()
        {
            
            var products = context.Products
                .Select(r => new ProductDto
                {
                    Id = r.Id,
                    ProductName = r.ProductName,
                    SKU = r.SKU,
                    RegularPrice = r.RegularPrice,
                    DiscountPrice = r.DiscountPrice,
                    Quantity = r.Quantity,
                    ProductWeight = r.ProductWeight,
                    Published = r.Published
                    


                }).ToList();

            return Ok(products);
        }


        [HttpPost("add-product")]

        public async Task<IActionResult> AddProduct([FromBody] ProductDto productDto)
        {
            var product = new Product()
            {
                Id = productDto.Id,
                ProductName = productDto.ProductName,
                SKU = productDto.SKU,
                RegularPrice = productDto.RegularPrice,
                DiscountPrice = productDto.DiscountPrice,
                Quantity = productDto.Quantity,
                ProductWeight = productDto.ProductWeight,
                Published = productDto.Published
            };

            
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
            return Ok(product);

        }

        [HttpDelete("delete-product")]
        public async Task<IActionResult> DeleteProduct([FromQuery] int id)
        {
           
            var product = await context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            context.Products.Remove(product);
            await context.SaveChangesAsync();
            return Ok();
        }



    }
}
