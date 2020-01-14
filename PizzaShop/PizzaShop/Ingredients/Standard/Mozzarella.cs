using PizzaShop.Ingredients.Standard.Texts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Standard
{
    public class Mozzarella : StandardIngredient
    {
        public Mozzarella(IProduct product) : base(product, new MozzarellaName()) { }
    }
}