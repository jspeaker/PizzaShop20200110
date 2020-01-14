using PizzaShop.Ingredients.Premium.Texts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Premium
{
    public class ThymeAndRosemary : PremiumIngredient
    {
        public ThymeAndRosemary(IProduct product) : base(product, new ThymeAndRosemaryName()) { }
    }
}