using PizzaShop.Currency;

namespace PizzaShop.Location
{
    public class BedrockLocation : Location<LzyCurrency>
    {
        public override bool IsLocation(LocationName locationName) => locationName == LocationName.Bedrock;
    }
}