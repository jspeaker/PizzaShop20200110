using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Ingredients;
using PizzaShop.Ingredients.Premium;
using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;
using PizzaShop.Sizes;

namespace PizzaShop.Unit.Tests.Ingredients
{
    [TestClass]
    public class PremiumIngredientsTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenPremiumIngredientOnPersonalPizza_WhenAskingForPrice_ThenItShouldReturnTwentyPercentOfThePizzaPrice()
        {
            // arrange
            IIngredient ingredient = new PremiumIngredientTestImplementation(new Pizza(new PersonalPizzaSize()));

            // act
            Money actual = ingredient.Price();

            // assert
            ((decimal)actual).Should().Be(1.80m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPremiumIngredientOnLargePizza_WhenAskingForPrice_ThenItShouldReturnFifteenPercentOfThePizzaPrice()
        {
            // arrange
            IIngredient ingredient = new PremiumIngredientTestImplementation(new Pizza(new LargePizzaSize()));

            // act
            Money actual = ingredient.Price();

            // assert
            ((decimal)actual).Should().Be(3.6m);
        }

        public class PremiumIngredientTestImplementation : PremiumIngredient
        {
            public PremiumIngredientTestImplementation(IProduct product) : base(product, new FakeIngredientName()) { }
        }
    }
}