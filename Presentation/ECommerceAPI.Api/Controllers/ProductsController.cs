using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
       

       
        [HttpGet]
        public IActionResult GetProducts()
        {
            
            return Ok();
        }
    }
}

