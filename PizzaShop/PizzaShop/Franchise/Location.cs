using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PizzaShop.Franchise
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LocationName
    {
        Bedrock,
        Springfield,
        Bricksburg
    }
}