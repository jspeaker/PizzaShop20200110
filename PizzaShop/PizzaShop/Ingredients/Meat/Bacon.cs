using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Meat
{
    public class Bacon : MeatIngredient
    {
        public Bacon(IProduct product) : base(product, new BaconName()) { }
    }

    public class BaconName : Text
    {
        public BaconName() : base("Bacon") { }
    }
}