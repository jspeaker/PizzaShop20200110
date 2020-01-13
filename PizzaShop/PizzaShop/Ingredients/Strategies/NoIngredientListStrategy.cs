namespace PizzaShop.Ingredients.Strategies
{
    public class NoIngredientListStrategy : IIngredientList
    {
        public string Formatted() => string.Empty;
    }
}