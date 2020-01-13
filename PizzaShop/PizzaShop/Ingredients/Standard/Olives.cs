using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Standard
{
    public class Olives : StandardIngredient
    {
        public Olives(IProduct product) : base(product, new OlivesName()) { }
    }

    public class OlivesName : Text
    {
        public OlivesName() : base("Olives") { }
    }
}