using ECommerceAPI.Application.Repositories.Products;
using ECommerceAPI.Application.RequestParameters;
using ECommerceAPI.Application.Services;
using ECommerceAPI.Application.ViewModels.Products;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ECommerceAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IFileServices _fileServices;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IWebHostEnvironment webHostEnvironment, IFileServices fileServices)
        {
            this._productReadRepository = productReadRepository;
            this._productWriteRepository = productWriteRepository;
            this._webHostEnvironment = webHostEnvironment;
            this._fileServices = fileServices;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery]Pagination pagination)
        {
            var totalCount = _productReadRepository.GetAll().Count();
            var products = _productReadRepository.GetAll().Skip(pagination.Size * pagination.Page).Take(pagination.Size).Select(p => new
            {
                p.Id,
                p.Name,
                p.Stock,
                p.Price,
                p.CreatedDate,
                p.UpdateDate


            }).ToList();
            return Ok(new
            {
                totalCount, products
            });
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);

        }
        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Product model)
        {
            if (ModelState.IsValid)
            {

            }
            await _productWriteRepository.CreateAsync(new()
            {
                Name = model.Name,
                Stock = model.Stock,
                Price = model.Price,

            });
            await _productWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_Product update_Product)
        {
            Product product = await _productReadRepository.GetByIdAsync(update_Product.Id);
            product.Name = update_Product.Name;
            product.Stock = update_Product.Stock;
            product.Price = update_Product.Price;
            await _productWriteRepository.SaveAsync();


            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _productWriteRepository.RemoveAsync(id);
            await _productWriteRepository.SaveAsync();
           
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Upload()
        {
            //string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "resource/product_Image");
            //if (!Directory.Exists(uploadPath))
            //    Directory.CreateDirectory(uploadPath);



            //Random random = new ();
            //foreach (IFormFile file in Request.Form.Files)
            //{

            //    string fulPath = Path.Combine(uploadPath, $"{random.Next()}{Path.GetExtension(file.FileName)}");
            //    using FileStream fileStream = new(fulPath, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);
            //    await file.CopyToAsync(fileStream);
            //    await fileStream.FlushAsync();
            //}
            //return Ok();
            await _fileServices.UploadAsync("resource/product-images", Request.Form.Files);
       
            return Ok();
        }

    }
}

//[Guid("8D9AAC36-C199-43BF-AE71-1E72FC47C897")]