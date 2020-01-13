using System.Linq;

namespace PizzaShop.Ingredients.Strategies
{
    public class MultiIngredientListStrategy : IIngredientList
    {
        private readonly IIngredient[] _ingredients;
        private readonly IIngredientList _nextStrategy;

        public MultiIngredientListStrategy(IIngredient[] ingredients) : this(ingredients, new SingleIngredientListStrategy(ingredients)) { }

        private MultiIngredientListStrategy(IIngredient[] ingredients, IIngredientList nextStrategy)
        {
            _ingredients = ingredients;
            _nextStrategy = nextStrategy;
        }

        public string Formatted()
        {
            if (_ingredients.Length < 2) return _nextStrategy.Formatted();

            string[] ingredientNames = _ingredients.Select(i => i.Name()).Select(i => i.ToString()).ToArray();
            return $" with {string.Join(", ", ingredientNames, 0, ingredientNames.Length - 1)} and {ingredientNames.Last()}";
        }
    }
}