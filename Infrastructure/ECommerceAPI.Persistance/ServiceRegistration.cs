using ECommerceAPI.Persistance.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ECommerceAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ECommerceDbContext>(options => options.UseSqlServer(Configiration.ConnectingString));

        }
    }
}
