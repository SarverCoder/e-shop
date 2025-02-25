using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class Role : IAuditable
    {

        public Role()
        {
            StaffRoles = new List<StaffRole>();
        }
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string[] Privilege { get; set; }
       
        public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual ICollection<StaffRole> StaffRoles { get; set; }
    }
}
