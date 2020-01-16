using PizzaShop.Currency;

namespace PizzaShop.Location
{
    public class SpringfieldLocation : Location<LzyCurrency>
    {
        public override bool IsLocation(LocationName locationName) => locationName == LocationName.Springfield;
    }
}