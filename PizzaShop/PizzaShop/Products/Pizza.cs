using PizzaShop.Ingredients;
using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products.Descriptions;
using PizzaShop.Sizes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaShop.Products
{
    public interface IProduct
    {
        string Description();
        decimal Price();
    }

    public class Pizza : IProduct
    {
        public Pizza() : this(new PersonalSize()) { }

        public Pizza(IProductSize size) : this(size, new IIngredient[0]) { }

        public Pizza(IProductSize size, IIngredient[] ingredients)
        {
            _size = size;
            _ingredients = ingredients;
        }

        private readonly string _productName = new PizzaProductName(); 

        private readonly IProductSize _size;
        private readonly IIngredient[] _ingredients;

        public string Description()
        {
            if (_ingredients == null || !_ingredients.Any()) return $"{_size} {_productName}";

            List<Text> ingredientNames = _ingredients.Select(i => i.Name()).ToList();
            return $"{_size} {_productName} with {string.Join(", ", ingredientNames.Select(i => i.ToString()))}";
        }

        public decimal Price()
        {
            if (_ingredients == null || !_ingredients.Any()) return _size.Price();

            return _size.Price() + _ingredients.Select(i => i.Price()).Sum(p => Convert.ToDecimal(p));
        }
    }
}