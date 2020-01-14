using PizzaShop.Ingredients.Meat.Texts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Meat
{
    public class Pepperoni : MeatIngredient
    {
        public Pepperoni(IProduct product) : base(product, new PepperoniName()) { }
    }
}