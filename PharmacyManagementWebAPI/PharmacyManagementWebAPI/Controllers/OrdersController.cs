using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyManagementWebAPI.Models;
using PharmacyManagementWebAPI.Repository;

namespace PharmacyManagementWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        
        public OrdersController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllOrders()
        {
            var orders = await _orderRepository.GetAllOrders();
            return Ok(orders);
        }
        [HttpPost("")]
        public async Task<IActionResult> AddOrder([FromBody] Order order)
        {
            var id=await _orderRepository.AddOrder(order);
            return CreatedAtAction(nameof(AddOrder), id);
        }
    }
}
