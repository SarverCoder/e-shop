using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class Tag : IAuditable
    {
        public Tag()
        {
            ProductTags = new List<ProductTag>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(255)]
        public string TagName { get; set; }
        public string Icon { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ICollection<ProductTag> ProductTags { get; set; }
    }
}
