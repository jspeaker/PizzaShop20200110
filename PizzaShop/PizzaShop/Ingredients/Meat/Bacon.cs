using PizzaShop.Franchise;
using PizzaShop.Ingredients.Meat.Texts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Meat
{
    public class Bacon : MeatIngredient
    {
        public Bacon(IProduct product) : base(product, new BaconName()) { }

        public override bool IsAvailableAt(Location location) => location != Location.ExpansionOne;
    }
}