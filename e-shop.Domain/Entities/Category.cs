using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("category")]
    public class Category
    {
       
        public int Id { get; set; }

        [ForeignKey("ParentCategory")]
        public int ParentId { get; set; }

        [Required]
        [MaxLength(255)]
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }
        public string Icon { get; set; }
        public string ImagePath { get; set; }

        public bool Active { get; set; }

       
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [Required]
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual Category ParentCategory { get; set; }

        public virtual ICollection<ProductCategory> ProductCategories { get; set; }


    }
}
