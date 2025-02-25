using e_shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.DataAccess.IServices
{
    public interface IOrder
    {
        public IEnumerable<Order> GetOrders();
        public Order GetOrderById(int id);
        void CreatedOrder(Order order);
        void UpdatedOrder(Order order);
        void DeleteOrder(int id);
    }
}
