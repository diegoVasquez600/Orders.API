using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Orders.API.DTO;

namespace Orders.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("GetOrders")]
        public string GetOrders()
        {
            OrdersDTO ordersDTO = new();
            var orders = JsonConvert.SerializeObject(ordersDTO.GetOrders());
            return orders;
        }
    }
}
