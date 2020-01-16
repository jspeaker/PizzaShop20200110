using PizzaShop.Currency;

namespace PizzaShop.Location
{
    public class BricksburgLocation : Location<BlkCurrency>
    {
        public override bool IsLocation(LocationName locationName) => locationName == LocationName.Bricksburg;
    }
}