using ECommerceAPI.Domain.Entities.Common;

namespace ECommerceAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        Task<bool> CreateAsync(T model);
        Task<bool> CreateRangeAsync(List<T> models);
        bool Update(T model);
        bool Remove(T model);
        Task<bool> RemoveAsync(string id);
        bool RemoveRange(List<T> models);

        Task<int> SaveAsync();
    }
}
