using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class Product
    {
       
        public int Id { get; set; }

       
        public string ProductName { get; set; }

       
        public string SKU { get; set; }

       
        public decimal RegularPrice { get; set; }

        public decimal DiscountPrice { get; set; }

        public int Quantity { get; set; }

       
        public string ShortDescription { get; set; }
        public string ProductDescription { get; set; }

       
        public decimal ProductWeight { get; set; }

       
        public string ProductNote { get; set; }
        public bool Published { get; set; }

        
        public DateTime CreatedAt { get; set; }

        
        public DateTime UpdatedAt { get; set; }

       
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        public virtual ICollection<ProductTag> ProductTags { get; set; }


    }
}
