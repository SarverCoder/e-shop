using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.DataAccess.Services
{
    public class OrderItemService
    {
        protected readonly ShopContext _context;

        public OrderItemService(ShopContext context)
        {
            _context = context;
        }

        

    }
}
