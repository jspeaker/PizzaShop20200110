using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Premium
{
    public class SundriedTomatoes : PremiumIngredient
    {
        public SundriedTomatoes(IProduct product) : base(product, new RoastedGarlicName()) { }
    }

    public class SundriedTomatoesName : Text
    {
        public SundriedTomatoesName() : base("Sundried Tomatoes") { }
    }
}