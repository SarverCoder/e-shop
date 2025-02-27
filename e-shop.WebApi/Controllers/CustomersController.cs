using e_shop.DataAccess;
using e_shop.Domain.Entities;
using e_shop.WebApi.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_shop.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ShopContext context;

    public CustomersController(ShopContext _context)
    {
        context = _context;
    }

    [HttpGet("all-customers")]
    public IActionResult GetAllCustomers()
    {
      

        var customers = context.Categories
            .Select(r => new CategoryDto()
            {
                Id = r.Id,
                CategoryName = r.CategoryName,
                CategoryDescription = r.CategoryDescription,  
                Icon = r.Icon
            }).ToList();

        return Ok(customers);
    }

    [HttpPost("add-customer")]

    public async Task<IActionResult> AddCustomer([FromBody] CategoryDto categoryDto)
    {
        var category = new Category()
        {
            CategoryName = categoryDto.CategoryName,
            CategoryDescription = categoryDto.CategoryDescription,
            Icon = categoryDto.Icon
        };

       
        await context.Categories.AddAsync(category);    
        await context.SaveChangesAsync();
        return Ok(category);
    }

    [HttpDelete("remove-customer")]

    public async Task<IActionResult> RemoveCustomer(int id)
    {
       
        var category = await context.Categories.FindAsync(id);
        if (category == null)
        {
            return NotFound();
        }
        context.Categories.Remove(category);
        await context.SaveChangesAsync();
        return Ok();
    }




}
