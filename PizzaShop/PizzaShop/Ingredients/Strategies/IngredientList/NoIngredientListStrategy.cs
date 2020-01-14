namespace PizzaShop.Ingredients.Strategies.IngredientList
{
    public class NoIngredientListStrategy : IIngredientList
    {
        public string Formatted() => string.Empty;
    }
}