﻿using PizzaShop.Location;
using PizzaShop.Products;
using System;

namespace PizzaShop.Ingredients.Mapping
{
    public class IngredientMap
    {
        private readonly Ingredients _ingredients;

        public IngredientMap() : this(new Ingredients()) { }

        private IngredientMap(Ingredients ingredients) => _ingredients = ingredients;

        public IIngredient DomainIngredient(string name, IProduct product, ILocation location)
        {
            IIngredient ingredient = (IIngredient) Activator.CreateInstance(_ingredients.Types[name], product);
            if (!ingredient.IsAvailableAt(location)) throw new Exception();

            return ingredient;
        }
    }
}