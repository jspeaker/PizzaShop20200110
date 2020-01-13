using System.Linq;

namespace PizzaShop.Ingredients.Strategies
{
    public class SingleIngredientListStrategy : IIngredientList
    {
        private readonly IIngredient[] _ingredients;
        private readonly IIngredientList _nextStrategy;

        public SingleIngredientListStrategy(IIngredient[] ingredients) : this(ingredients, new NoIngredientListStrategy()) { }

        private SingleIngredientListStrategy(IIngredient[] ingredients, IIngredientList nextStrategy)
        {
            _ingredients = ingredients;
            _nextStrategy = nextStrategy;
        }

        public string Formatted()
        {
            if (_ingredients.Length != 1) return _nextStrategy.Formatted();

            string[] ingredientNames = _ingredients.Select(i => i.Name()).Select(i => i.ToString()).ToArray();
            return $" with {string.Join(", ", ingredientNames)}";
        }
    }
}