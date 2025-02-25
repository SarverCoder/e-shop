using Castle.Core.Logging;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.DataAccess.Interceptors;

public class ConnectionInterseptor(ILogger<ConnectionInterseptor> logger) : DbConnectionInterceptor
{
    public override Task ConnectionOpenedAsync(DbConnection connection,
        ConnectionEndEventData eventData, CancellationToken cancellationToken = default)
    {
        logger.LogInformation("Connection Opened.");

        return base.ConnectionOpenedAsync(connection, eventData, cancellationToken);
    }

    public override Task ConnectionClosedAsync(DbConnection connection, ConnectionEndEventData eventData)
    {
        logger.LogInformation("Connection Closed.");

        return base.ConnectionClosedAsync(connection, eventData);
    }

}
