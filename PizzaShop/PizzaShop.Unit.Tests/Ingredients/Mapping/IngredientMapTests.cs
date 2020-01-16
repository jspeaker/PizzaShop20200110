﻿using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Franchise;
using PizzaShop.Ingredients;
using PizzaShop.Ingredients.Mapping;
using PizzaShop.Ingredients.Meat;
using PizzaShop.Ingredients.Meat.Texts;
using PizzaShop.Ingredients.Premium.Texts;
using PizzaShop.Ingredients.Standard.Texts;
using PizzaShop.Products;
using System;

namespace PizzaShop.Unit.Tests.Ingredients.Mapping
{
    [TestClass]
    public class IngredientMapTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenExistingIngredientName_WhenAskingToMap_ThenItShouldReturnCorrectIngredient()
        {
            // arrange
            const string name = "Olives";
            IngredientMap ingredientMap = new IngredientMap();

            // act
            IIngredient mappedIngredient = ingredientMap.DomainIngredient(name, new Pizza(), LocationName.Bedrock);

            // assert
            mappedIngredient.Name().ToString().Should().BeEquivalentTo(new OlivesName());
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenExistingAlternativeIngredientName_WhenAskingToMap_ThenItShouldReturnCorrectIngredient()
        {
            // arrange
            const string name = "Crispy Ham";
            IngredientMap ingredientMap = new IngredientMap();

            // act
            IIngredient mappedIngredient = ingredientMap.DomainIngredient(name, new Pizza(), LocationName.Springfield);

            // assert
            mappedIngredient.Name().ToString().Should().BeEquivalentTo(new CrispyHamName());
            mappedIngredient.GetType().Name.Should().Be(nameof(CrispyHam));
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenExistingDefaultIngredientNameAvailableAtLocation_WhenAskingToMap_ThenItShouldNotThrow()
        {
            // arrange
            const string name = "Bacon";
            IngredientMap ingredientMap = new IngredientMap();

            // act
            Action action = () => ingredientMap.DomainIngredient(name, new Pizza(), LocationName.Bedrock);

            // assert
            action.Should().NotThrow<Exception>();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenExistingDefaultIngredientNameNotAvailableAtLocation_WhenAskingToMap_ThenItShouldThrow()
        {
            // arrange
            const string name = "Bacon";
            IngredientMap ingredientMap = new IngredientMap();

            // act
            Action action = () => ingredientMap.DomainIngredient(name, new Pizza(), LocationName.Springfield);

            // assert
            action.Should().Throw<Exception>();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenExistingAlternativeIngredientNameAvailableAtLocation_WhenAskingToMap_ThenItShouldNotThrow()
        {
            // arrange
            const string name = "Crispy Ham";
            IngredientMap ingredientMap = new IngredientMap();

            // act
            Action action = () => ingredientMap.DomainIngredient(name, new Pizza(), LocationName.Springfield);

            // assert
            action.Should().NotThrow<Exception>();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenExistingAlternativeIngredientNameNotAvailableAtLocation_WhenAskingToMap_ThenItShouldThrow()
        {
            // arrange
            const string name = "Crispy Ham";
            IngredientMap ingredientMap = new IngredientMap();

            // act
            Action action = () => ingredientMap.DomainIngredient(name, new Pizza(), LocationName.Bedrock);

            // assert
            action.Should().Throw<Exception>();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenExistingIngredientNameAvailableAtLocation_WhenAskingToMap_ThenItShouldReturnCorrectIngredient()
        {
            // arrange
            const string name = "Roasted Garlic";
            IngredientMap ingredientMap = new IngredientMap();

            // act
            IIngredient mappedIngredient = ingredientMap.DomainIngredient(name, new Pizza(), LocationName.Bedrock);

            // assert
            mappedIngredient.Name().ToString().Should().BeEquivalentTo(new RoastedGarlicName());
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenExistingIngredientNameNotAvailableAtLocation_WhenAskingToMap_ThenItShouldThrow()
        {
            // arrange
            const string name = "Roasted Garlic";
            IngredientMap ingredientMap = new IngredientMap();

            // act
            Action action = () => ingredientMap.DomainIngredient(name, new Pizza(), LocationName.Springfield);

            // assert
            action.Should().Throw<Exception>();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenNonExistentIngredientName_WhenAskingToMap_ThenItShouldThrow()
        {
            // arrange
            const string name = "Dammit, Bobby!";
            IngredientMap ingredientMap = new IngredientMap();

            // act
            Action action = () => ingredientMap.DomainIngredient(name, new Pizza(), LocationName.Bedrock);

            // assert
            action.Should().Throw<Exception>();
        }
    }
}