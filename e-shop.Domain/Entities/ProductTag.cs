using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class ProductTag
    {
        public int TagId { get; set; }
        public int ProductId { get; set; }  

        public Tag Tag { get; set; }
        public Product Product { get; set; }
    }
}
