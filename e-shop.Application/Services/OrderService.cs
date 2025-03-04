using e_shop.DataAccess.IServices;
using e_shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.DataAccess.Services
{
    public class OrderService : IOrder
    {
        private readonly ShopContext _context;

        public OrderService(ShopContext context)
        {
            _context = context;
        }

        public void CreatedOrder(Order order)
        {
            _context.Orders.Add(order);
            Console.WriteLine(_context.Entry(order).State);
            _context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var order = _context.Orders.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                Console.WriteLine(_context.Entry(order).State);
                _context.SaveChanges();
            }
        }

        public Order GetOrderById(int id)
        {

            return _context.Orders.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }

        public void UpdatedOrder(Order order)
        {
            _context.Orders.Update(order);
            Console.WriteLine(_context.Entry(order).State);
            _context.SaveChanges();
        }
    }
}
