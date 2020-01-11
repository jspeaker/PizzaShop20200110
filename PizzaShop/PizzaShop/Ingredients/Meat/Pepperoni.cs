using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Meat
{
    public class Pepperoni : MeatIngredient
    {
        public Pepperoni(IProduct product) : base(product, new PepperoniName()) { }
    }

    public class PepperoniName : Text
    {
        public PepperoniName() : base("pepperoni") { }
    }
}