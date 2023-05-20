using ECommerceAPI.Persistance.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ECommerceAPI.Application.Repositories.Orders;
using ECommerceAPI.Persistance.Repositories.Orders;
using ECommerceAPI.Application.Repositories.Products;
using ECommerceAPI.Persistance.Repositories.Products;
using ECommerceAPI.Application.Repositories.Customers;
using ECommerceAPI.Persistance.Repositories.Customers;
using ECommerceAPI.Application.Repositories;

namespace ECommerceAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ECommerceDbContext>(options => options.UseSqlServer(Configiration.ConnectingString), ServiceLifetime.Singleton);

            serviceCollection.AddSingleton<IOrderReadRepository, OrderReadRepository>();   
            serviceCollection.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();   
            serviceCollection.AddSingleton<IProductReadRepository, ProductReadRepository>();   
            serviceCollection.AddSingleton<IProductWriteRepository, ProductWriteRepository>();   
            serviceCollection.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();   
            serviceCollection.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();   

        }
    }
}
