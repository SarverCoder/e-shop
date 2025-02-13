using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.DataAccess.ModelConfigurations
{
    public class StaffRoleConfiguration : IEntityTypeConfiguration<StaffRole>
    {
        public void Configure(EntityTypeBuilder<StaffRole> builder)
        {
            builder.HasKey(k => new
            {
                k.StaffID,
                k.RoleId
            });

            builder.HasOne(x => x.StaffAccount)
            .WithMany(x => x.StaffRoles)
            .HasForeignKey(sr => sr.StaffID);

            builder
            .HasOne(sr => sr.Role)
            .WithMany(x => x.StaffRoles)
            .HasForeignKey(sr => sr.RoleId);
        }
    }
}
