using ECommerceAPI.Persistance.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ECommerceDbContext>(options=> options.UseSqlServer("Server=DESKTOP-J2UHGTK;Database=ECommerceDb;Trusted_Connection=True;TrustServerCertificate=True"));
        }
    }
}
