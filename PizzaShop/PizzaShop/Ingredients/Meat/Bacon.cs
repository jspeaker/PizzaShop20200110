using PizzaShop.Ingredients.Meat.Texts;
using PizzaShop.Location;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Meat
{
    public class Bacon : MeatIngredient
    {
        public Bacon(IProduct product) : base(product, new BaconName()) { }

        public override bool IsAvailableAt(ILocation location) => !location.IsLocation(LocationName.Springfield);
    }
}