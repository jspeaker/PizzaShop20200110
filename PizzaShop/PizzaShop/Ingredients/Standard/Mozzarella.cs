using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Standard
{
    public class Mozzarella : StandardIngredient
    {
        public Mozzarella(IProduct product) : base(product, new MozzarellaName()) { }
    }

    public class MozzarellaName : Text
    {
        public MozzarellaName() : base("mozzarella") { }
    }
}