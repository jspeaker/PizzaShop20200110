﻿using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Ingredients;
using PizzaShop.Ingredients.Meat;
using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;
using PizzaShop.Sizes;

namespace PizzaShop.Unit.Tests.Ingredients
{
    [TestClass]
    public class MeatIngredientsTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenMeatIngredientOnPersonalPizza_WhenAskingForPrice_ThenItShouldReturnFifteenPercentOfThePizzaPrice()
        {
            // arrange
            IIngredient ingredient = new MeatIngredientTestImplementation(new Pizza(new PersonalPizzaSize()));

            // act
            Money actual = ingredient.Price();

            // assert
            ((decimal)actual).Should().Be(1.35m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenMeatIngredientOnLargePizza_WhenAskingForPrice_ThenItShouldReturnFifteenPercentOfThePizzaPrice()
        {
            // arrange
            IIngredient ingredient = new MeatIngredientTestImplementation(new Pizza(new LargePizzaSize()));

            // act
            Money actual = ingredient.Price();

            // assert
            ((decimal)actual).Should().Be(2.7m);
        }

        public class MeatIngredientTestImplementation : MeatIngredient
        {
            public MeatIngredientTestImplementation(IProduct product) : base(product, new FakeIngredientName()) { }
        }
    }
}