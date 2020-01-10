using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Sizes;

namespace PizzaShop.Unit.Tests
{
    [TestClass]
    public class ProductDescriptionTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenDefaultPizza_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza();

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Personal Pizza");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFamilySizePizza_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new FamilySize());

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Family Pizza");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizza_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new PersonalSize());

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Personal Pizza");
        }
    }
}
