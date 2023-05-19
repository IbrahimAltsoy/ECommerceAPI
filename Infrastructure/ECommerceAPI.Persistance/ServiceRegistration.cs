using ECommerceAPI.Application.Abstractions;
using ECommerceAPI.Persistance.Concreates;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IProductService, ProductService>();
        }
    }
}
