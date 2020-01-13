using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Meat
{
    public class Ham : MeatIngredient
    {
        public Ham(IProduct product) : base(product, new HamName()) { }
    }

    public class HamName : Text
    {
        public HamName() : base("Ham") { }
    }
}