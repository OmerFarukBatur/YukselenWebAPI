using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using YukselenWebAPI.DAL;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.BL
{
    public static class ServiceRegistration
    {
        public static void AddBLServices(this IServiceCollection services)
        {
            services.AddDbContext<YukselenDBContext>(options => options.UseSqlServer(Configuration.ConfigurationString));            
        }
    }
}
