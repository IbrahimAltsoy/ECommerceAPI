using ECommerceAPI.Application.Repositories.Orders;
using ECommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;
        public OrderController(IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository)
        {
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
        }
        //[HttpGet]
        //public async Task AddedOrder()
        //{
        //    await _orderWriteRepository.CreateAsync(new()
        //    {
        //        Address = "West PalmBeach", Description = "Tatil koyu", CustomerId= Guid.Parse("1249860a-c34f-4008-af70-d47b331a1b9d")
        //    });
        //    await _orderWriteRepository.SaveAsync();
        //}
        [HttpGet]
        public async Task OrderUpdate()
        {
            Order order = await _orderReadRepository.GetByIdAsync("affdf1c4-d713-4fcf-00ae-08db59843d10");
            order.Description = "Merhaba";
            order.Address = "West Palm";
           await _orderWriteRepository.SaveAsync();
            
           
        }
       
        
    }
}
