using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Domain.Entities.Common;

namespace ECommerceAPI.Application.Repositories.Orders
{
    public interface IOrderReadRepository : IReadRepository<Order>
    {
    }
}
