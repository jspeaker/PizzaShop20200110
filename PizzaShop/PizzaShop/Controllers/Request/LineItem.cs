using Newtonsoft.Json;

namespace PizzaShop.Controllers.Request
{
    public class LineItem
    {
        [JsonProperty("Description")]
        private readonly string _description;
        [JsonProperty("Price")]
        private readonly string _price;

        [JsonConstructor]
        public LineItem(string description, string price)
        {
            _description = description;
            _price = price;
        }
    }
}