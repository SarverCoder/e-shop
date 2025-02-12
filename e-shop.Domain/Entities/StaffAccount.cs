using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class StaffAccount
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool Active { get; set; }
        public string ProfileImg { get; set; }
        public DateTime RegisteredAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdateBy { get; set; }

        public ICollection<StaffRole> StaffRoles { get; set; }
    }
}
