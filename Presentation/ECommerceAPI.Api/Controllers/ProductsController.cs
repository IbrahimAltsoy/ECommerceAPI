using ECommerceAPI.Application.Repositories.Products;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository productReadRepository;
        private readonly IProductWriteRepository productWriteRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            this.productReadRepository = productReadRepository;
            this.productWriteRepository = productWriteRepository;
        }


        [HttpGet]
        public async void Get()
        {
           await productWriteRepository.CreateRangeAsync(new()
            {
                new(){Id = Guid.NewGuid(), Name = "Product-1", CreatedDate = DateTime.Now, Price = 100, Stock= 5},
                new(){Id = Guid.NewGuid(), Name = "Product-2", CreatedDate = DateTime.Now, Price = 200, Stock= 15},
                new(){Id = Guid.NewGuid(), Name = "Product-3", CreatedDate = DateTime.Now, Price = 300, Stock= 25},
                new(){Id = Guid.NewGuid(), Name = "Product-1", CreatedDate = DateTime.Now, Price = 400, Stock= 35},
                new(){Id = Guid.NewGuid(), Name = "Product-1", CreatedDate = DateTime.Now, Price = 500, Stock= 45},
            });
            await productWriteRepository.SaveAsync();
        }
    }
}

