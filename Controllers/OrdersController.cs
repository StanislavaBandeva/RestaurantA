using RestaurantA.BL.Interfaces;
using RestaurantA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace RestaurantA.Controllers
{
    [ApiController]
    [Route("controller")]
    public class OrdersController : ControllerBase
    {
        private readonly IRabbitMqService _rabbitMq;

        public OrdersController(IRabbitMqService rabbitMq)
        {
            _rabbitMq = rabbitMq;
        }

        [HttpPost("Publish Order to RabbitMQ")]
        public async Task<IActionResult> ProduceOrder([FromBody] Order order)
        {
            await _rabbitMq.PublishOrderAsync(order);

            return Ok();
        }
    }
}
