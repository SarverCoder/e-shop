using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class ProductCategory
    {
        [Key]
        [Column(Order = 1)]
        public int ProductId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int CategoryId { get; set; }



        public virtual Product Product { get; set; }
        public virtual Category Category { get; set; }

    }
}
