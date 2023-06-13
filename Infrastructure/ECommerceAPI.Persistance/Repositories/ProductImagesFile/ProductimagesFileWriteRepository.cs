using ECommerceAPI.Application.Repositories.ProductImageFile;
using ECommerceAPI.Persistance.Contexts;
using P = ECommerceAPI.Domain.Entities;
namespace ECommerceAPI.Persistance.Repositories.ProductImagesFile
{
    public class ProductimagesFileWriteRepository : WriteRepository<P.ProductImageFile>, IProductImagesFileWriteRepository
    {
        public ProductimagesFileWriteRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
}
