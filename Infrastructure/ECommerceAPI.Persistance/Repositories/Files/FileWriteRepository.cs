using ECommerceAPI.Application.Repositories.File;
using ECommerceAPI.Persistance.Contexts;
using F= ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Persistance.Repositories.Files
{
    public class FileWriteRepository : WriteRepository<F.File>, IFileWriteRepository
    {
        public FileWriteRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
}
