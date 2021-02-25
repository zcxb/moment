using Furion;
using Microsoft.Extensions.DependencyInjection;

namespace Zcxb.Moment.EntityFramework.Core
{
    public class Startup : AppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseAccessor(options =>
            {
                options.AddDbPool<DefaultDbContext>();
            }, "Zcxb.Moment.Database.Migrations");
        }
    }
}