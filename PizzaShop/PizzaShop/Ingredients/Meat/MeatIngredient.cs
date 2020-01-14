using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Meat
{
    public abstract class MeatIngredient : Ingredient
    {
        protected MeatIngredient(IProduct product, Text name) : base(new CalculatedMoney(product.Price() * .15m), name) { }
    }
}