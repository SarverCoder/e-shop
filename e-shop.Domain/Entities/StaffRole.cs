using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class StaffRole
    {
        public int StaffID { get; set; }
        public int RoleId { get; set; } 

        public virtual StaffAccount StaffAccount { get; set; }
        public virtual Role Role { get; set; }

    }
}
