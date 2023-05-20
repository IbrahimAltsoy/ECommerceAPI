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
            serviceCollection.AddDbContext<ECommerceDbContext>(options => options.UseSqlServer(Configiration.ConnectingString));

            serviceCollection.AddScoped<IOrderReadRepository, OrderReadRepository>();   
            serviceCollection.AddScoped<IOrderWriteRepository, OrderWriteRepository>();   
            serviceCollection.AddScoped<IProductReadRepository, ProductReadRepository>();   
            serviceCollection.AddScoped<IProductWriteRepository, ProductWriteRepository>();   
            serviceCollection.AddScoped<ICustomerReadRepository, CustomerReadRepository>();   
            serviceCollection.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();   

        }
    }
}
