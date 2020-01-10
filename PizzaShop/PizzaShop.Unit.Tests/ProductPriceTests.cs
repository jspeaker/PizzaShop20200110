using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Sizes;

namespace PizzaShop.Unit.Tests
{
    [TestClass]
    public class ProductPriceTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenDefaultPizza_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza();

            // act
            decimal actual = pizza.Price();

            // assert
            actual.Should().Be(9.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFamilySizePizza_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new FamilySize());

            // act
            decimal actual = pizza.Price();

            // assert
            actual.Should().Be(18.0m);
        }
    }
}