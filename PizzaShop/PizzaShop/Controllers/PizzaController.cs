using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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

        [HttpGet]
        public Pizza Get()
        {
            IProduct pizza = new Pizza();
            _logger.LogInformation(pizza.Description());
            return (Pizza) pizza;
        }
    }
}
