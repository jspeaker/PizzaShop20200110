using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Standard
{
    public class Mushrooms : StandardIngredient
    {
        public Mushrooms(IProduct product) : base(product, new MushroomsName()) { }
    }

    public class MushroomsName : Text
    {
        public MushroomsName() : base("Mushrooms") { }
    }
}