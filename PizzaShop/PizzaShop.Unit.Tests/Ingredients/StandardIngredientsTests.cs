using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Ingredients;
using PizzaShop.Ingredients.Standard;
using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;
using PizzaShop.Sizes;

namespace PizzaShop.Unit.Tests.Ingredients
{
    [TestClass]
    public class StandardIngredientsTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenStandardIngredientOnPersonalPizza_WhenAskingForPrice_ThenItShouldReturnTenPercentOfThePizzaPrice()
        {
            // arrange
            IIngredient ingredient = new StandardIngredientTestImplementation(new Pizza(new PersonalSize()), new FakeIngredientName());

            // act
            Money actual = ingredient.Price();

            // assert
            ((decimal)actual).Should().Be(.9m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenStandardIngredientOnFamilyPizza_WhenAskingForPrice_ThenItShouldReturnTenPercentOfThePizzaPrice()
        {
            // arrange
            IIngredient ingredient = new StandardIngredientTestImplementation(new Pizza(new FamilySize()), new FakeIngredientName());

            // act
            Money actual = ingredient.Price();

            // assert
            ((decimal)actual).Should().Be(1.8m);
        }

        public class StandardIngredientTestImplementation : StandardIngredient
        {
            public StandardIngredientTestImplementation(IProduct product, Text name) : base(product, name) { }
        }
    }
}