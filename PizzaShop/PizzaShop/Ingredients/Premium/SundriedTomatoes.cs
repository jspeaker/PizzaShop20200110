using PizzaShop.Ingredients.Premium.Texts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Premium
{
    public class SundriedTomatoes : PremiumIngredient
    {
        public SundriedTomatoes(IProduct product) : base(product, new RoastedGarlicName()) { }
    }
}