using Accountant.Data;
using Accountant.Helpers.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Accountant.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceProvider Migrate(this IServiceProvider serviceProvider)
        {
            using var serviceScope = serviceProvider.CreateScope();

            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
            context.Database.Migrate();

            return serviceProvider;
        }
    }
}
