using System.Collections.Generic;
using Newtonsoft.Json;

namespace PizzaShop.Controllers.Request
{
    public class Invoice
    {
        public Invoice(List<LineItem> lineItems) => _lineItems = lineItems;

        [JsonProperty("LineItems")]
        private readonly List<LineItem> _lineItems;
    }
}