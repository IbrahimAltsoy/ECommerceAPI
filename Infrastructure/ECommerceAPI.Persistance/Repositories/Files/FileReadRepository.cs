using ECommerceAPI.Application.Repositories.File;
using ECommerceAPI.Persistance.Contexts;
using F = ECommerceAPI.Domain.Entities;
namespace ECommerceAPI.Persistance.Repositories.Files
{
    public class FileReadRepository : ReadRepository<F.File>, IFileReadRepository
    {
        public FileReadRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
}
