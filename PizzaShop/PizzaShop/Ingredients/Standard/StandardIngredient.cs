using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Standard
{
    public abstract class StandardIngredient : Ingredient
    {
        protected StandardIngredient(IProduct product, Text name) : base(new CalculatedMoney(product.Price() * .1m), name) { }
    }
}