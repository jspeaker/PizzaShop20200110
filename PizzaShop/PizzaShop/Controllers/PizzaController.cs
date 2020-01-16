using Microsoft.AspNetCore.Mvc;
using PizzaShop.Controllers.Request;

namespace PizzaShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        [HttpPost]
        public ActionResult Post(Order order) => Ok(order.Invoice());
    }
}
