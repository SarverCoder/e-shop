using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class StaffAccount : IAuditable
    {
        public StaffAccount()
        {
            StaffRoles = new List<StaffRole>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool Active { get; set; }
        public string ProfileImg { get; set; }
       
        public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual ICollection<StaffRole> StaffRoles { get; set; }
    }
}
