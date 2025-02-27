using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class Order
    {
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public DateTime OrderApprovedAt { get; set; }
        public DateTime OrderDeliveredCarrierDate {  get; set; }
        public DateTime OrderDeliveredCustomerDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
