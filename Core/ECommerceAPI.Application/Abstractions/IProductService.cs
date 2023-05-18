using ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Application.Abstractions
{
    public interface IProductService
    {
        public List<Product> GetAllProducts();
    }
}
