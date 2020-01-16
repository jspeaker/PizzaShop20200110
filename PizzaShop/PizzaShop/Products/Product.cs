using PizzaShop.Ingredients;
using PizzaShop.Ingredients.Strategies.IngredientList;
using PizzaShop.PrimitiveConcepts;
using PizzaShop.Sizes;
using System;
using System.Linq;

namespace PizzaShop.Products
{
    public abstract class Product : IProduct
    {
        private readonly Text _productName;

        private readonly IProductSize _size;
        private readonly IIngredient[] _ingredients;
        private readonly IIngredientList _ingredientListStrategy;

        protected Product(IProductSize size, IIngredient[] ingredients, Text productName) : this(size, ingredients, new MultiIngredientListStrategy(ingredients)) => _productName = productName;

        private Product(IProductSize size, IIngredient[] ingredients, IIngredientList ingredientListStrategy)
        {
            _size = size;
            _ingredients = ingredients;
            _ingredientListStrategy = ingredientListStrategy;
        }

        public string Description() => $"{_size} {_productName}{_ingredientListStrategy.Formatted()}";

        public Money Price()
        {
            if (_ingredients == null || !_ingredients.Any()) return _size.Price();

            return new CalculatedPrice(_size.Price() + _ingredients.Select(i => i.Price()).Sum(p => Convert.ToDecimal(p)));
        }
    }

    public class CalculatedPrice : Money
    {
        public CalculatedPrice(decimal value) : base(value) { }
    }
}