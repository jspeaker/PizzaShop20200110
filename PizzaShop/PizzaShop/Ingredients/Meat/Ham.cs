using PizzaShop.Ingredients.Meat.Texts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Meat
{
    public class Ham : MeatIngredient
    {
        public Ham(IProduct product) : base(product, new HamName()) { }
    }
}