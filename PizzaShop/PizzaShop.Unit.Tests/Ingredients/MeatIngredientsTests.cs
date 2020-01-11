using FluentAssertions;
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
        public void GivenStandardIngredientOnPersonalPizza_WhenAskingForPrice_ThenItShouldReturnFifteenPercentOfThePizzaPrice()
        {
            // arrange
            IIngredient ingredient = new MeatIngredientTestImplementation(new Pizza(new PersonalSize()));

            // act
            Money actual = ingredient.Price();

            // assert
            ((decimal)actual).Should().Be(1.35m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenStandardIngredientOnFamilyPizza_WhenAskingForPrice_ThenItShouldReturnFifteenPercentOfThePizzaPrice()
        {
            // arrange
            IIngredient ingredient = new MeatIngredientTestImplementation(new Pizza(new FamilySize()));

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