using PizzaShop.Ingredients.Standard.Texts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Standard
{
    public class Mushrooms : StandardIngredient
    {
        public Mushrooms(IProduct product) : base(product, new MushroomsName()) { }
    }
}