using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string[] Privilege { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual ICollection<StaffRole> StaffRoles { get; set; }

    }
}
