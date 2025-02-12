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

        public StaffAccount StaffAccount { get; set; }
        public Role Role { get; set; }

    }
}
