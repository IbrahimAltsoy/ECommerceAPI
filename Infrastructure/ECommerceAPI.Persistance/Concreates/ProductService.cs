using ECommerceAPI.Application.Abstractions;
using ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Persistance.Concreates
{
    public class ProductService : IProductService
    {
        public List<Product> GetAllProducts()
       => new()
       {
           new Product{ Id= Guid.NewGuid(), Name= "Product-1", Price = 100, Stock= 50 },
           new Product{ Id= Guid.NewGuid(), Name= "Product-2", Price = 110, Stock= 40 },
           new Product{ Id= Guid.NewGuid(), Name= "Product-3", Price = 120, Stock= 30 },
           new Product{ Id= Guid.NewGuid(), Name= "Product-4", Price = 130, Stock= 20 },
           new Product{ Id= Guid.NewGuid(), Name= "Product-5", Price = 140, Stock= 10 }
       };
    }
}
