using e_shop.DataAccess;
using e_shop.Domain.Entities;
using e_shop.Domain.ViewsModels;
using e_shop.Application.Dtos;   
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_shop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ShopContext _context;

        public OrdersController(ShopContext context)
        {
            _context = context;
        }

        [HttpGet("filtered-orders")]
        public async Task<IActionResult> GetFunction([FromQuery] DateTime from, [FromQuery] DateTime to)
        {
            DateTime fromDate = DateTime.SpecifyKind(from, DateTimeKind.Utc);
            DateTime toDate = DateTime.SpecifyKind(to, DateTimeKind.Utc);

            

            var orders = await _context.BetweenOrders
                .FromSqlRaw(@"SELECT * FROM public.""SP_GetOrders""({0}, {1})", fromDate, toDate)
                .ToListAsync();

            if(orders is null)
            {
                return NotFound();
            }

            return Ok(orders);
        }


        [HttpGet("get-last-orders")]
        public async Task<ActionResult<IEnumerable<LastYearOrderModel>>> GetLastYearOrders()
        {
            var orders = await _context.LastYearOrderModels.AsNoTracking().ToListAsync();

            if(orders is null)
            {
                return NotFound();
            }


            return Ok(orders);
        }





        [HttpPost("create-order/{customerId}")]

        public IActionResult CreateOrder(
            [FromRoute] int customerId, [FromBody] OrderDto orderDto)
        {
            


            var customer = _context.Customers.Find(customerId);

            if (customer == null)
            {
                return NotFound();
            }

            var order = new Order()
            {
                Id = orderDto.Id,
                CustomerId = customerId,
                OrderApprovedAt = orderDto.OrderApprovedAt,
                OrderDeliveredCarrierDate = orderDto.OrderDeliveredCarrierDate,
                OrderDeliveredCustomerDate = orderDto.OrderDeliveredCustomerDate
            };

            _context.Orders.Add(order);
            _context.SaveChanges();

            return Ok(order);
        }
    }
}
