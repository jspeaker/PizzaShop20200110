using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Ingredients;
using PizzaShop.Ingredients.Mapping;
using PizzaShop.Ingredients.Standard;
using PizzaShop.Products;
using System;

namespace PizzaShop.Unit.Tests.Ingredients.Mapping
{
    [TestClass]
    public class IngredientViewModelTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenExistingIngredientName_WhenAskingToMap_ThenItShouldReturnCorrectIngredient()
        {
            // arrange
            const string name = "olives";
            IngredientMap ingredientMap = new IngredientMap();

            // act
            IIngredient mappedIngredient = ingredientMap.DomainIngredient(name, new Pizza());

            // assert
            mappedIngredient.Name().ToString().Should().BeEquivalentTo(new OlivesName());
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenNonExistentIngredientName_WhenAskingToMap_ThenItShouldThrow()
        {
            // arrange
            const string name = "Dammit, Bobby!";
            IngredientMap ingredientMap = new IngredientMap();

            // act
            Action action = () => ingredientMap.DomainIngredient(name, new Pizza());

            // assert
            action.Should().Throw<Exception>();
        }
    }
}