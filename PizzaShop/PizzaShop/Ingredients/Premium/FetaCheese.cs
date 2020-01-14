using PizzaShop.Ingredients.Premium.Texts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Premium
{
    public class FetaCheese : PremiumIngredient
    {
        public FetaCheese(IProduct product) : base(product, new FetaCheeseName()) { }
    }
}