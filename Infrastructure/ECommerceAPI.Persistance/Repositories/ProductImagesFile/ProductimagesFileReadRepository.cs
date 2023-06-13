using ECommerceAPI.Application.Repositories.ProductImageFile;
using ECommerceAPI.Persistance.Contexts;
using P = ECommerceAPI.Domain.Entities;


namespace ECommerceAPI.Persistance.Repositories.ProductImagesFile
{
    public class ProductimagesFileReadRepository : ReadRepository<P.ProductImageFile>, IProductImageFileReadRepository
    {
        public ProductimagesFileReadRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
}
