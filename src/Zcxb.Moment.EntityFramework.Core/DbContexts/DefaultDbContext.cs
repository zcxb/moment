using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace Zcxb.Moment.EntityFramework.Core
{
    [AppDbContext("Zcxb.Moment", DbProvider.Sqlite)]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
        }
    }
}