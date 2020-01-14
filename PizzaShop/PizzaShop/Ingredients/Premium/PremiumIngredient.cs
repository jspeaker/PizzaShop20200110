using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Premium
{
    public abstract class PremiumIngredient : Ingredient
    {
        protected PremiumIngredient(IProduct product, Text name) : base(new CalculatedMoney(product.Price() * .2m), name) { }
    }
}