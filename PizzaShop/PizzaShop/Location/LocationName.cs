using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PizzaShop.Location
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LocationName
    {
        Bedrock,
        Springfield,
        Bricksburg
    }
}