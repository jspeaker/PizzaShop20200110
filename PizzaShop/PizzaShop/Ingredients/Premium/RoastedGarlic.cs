using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Premium
{
    public class RoastedGarlic : PremiumIngredient
    {
        public RoastedGarlic(IProduct product) : base(product, new RoastedGarlicName()) { }
    }

    public class RoastedGarlicName : Text
    {
        public RoastedGarlicName() : base("Roasted Garlic") { }
    }
}