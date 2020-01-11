using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaShop.Controllers.Request;

namespace PizzaShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public string Post(Order order)
        {
            _logger.LogInformation(order.Invoice());
            return order.Invoice();
        }
    }
}
