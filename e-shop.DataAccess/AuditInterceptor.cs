using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.DataAccess;

public class AuditInterceptor : SaveChangesInterceptor
{
    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        var enries = eventData.Context
            .ChangeTracker
            .Entries()
            .Where(r => r.Entity is IAuditable);

        foreach (var e in enries)
        {
            var entity = (IAuditable)e.Entity;

            if (e.State == EntityState.Added)
            {
                
                entity.CreatedAt = DateTime.UtcNow;
                entity.CreatedBy = 1;

            }

            if (e.State == EntityState.Modified)
            {
                entity.UpdatedAt = DateTime.UtcNow;
                entity.UpdatedBy = 1;
            }

        }      

        return base.SavingChanges(eventData, result);
    }
}
