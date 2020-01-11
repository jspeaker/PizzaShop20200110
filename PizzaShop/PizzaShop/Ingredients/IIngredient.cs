using PizzaShop.PrimitiveConcepts;

namespace PizzaShop.Ingredients
{
    public interface IIngredient
    {
        Money Price();
        Text Name();
    }
}