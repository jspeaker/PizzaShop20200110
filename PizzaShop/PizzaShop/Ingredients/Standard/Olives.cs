using PizzaShop.Ingredients.Standard.Texts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Standard
{
    public class Olives : StandardIngredient
    {
        public Olives(IProduct product) : base(product, new OlivesName()) { }
    }
}