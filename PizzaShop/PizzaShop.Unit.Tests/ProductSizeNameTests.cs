using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Sizes;

namespace PizzaShop.Unit.Tests
{
    [TestClass]
    public class ProductSizeNameTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenDefaultPizza_WhenAskingIfPersonalSize_ThenItShouldReturnTrue()
        {
            // arrange
            IProduct pizza = new Pizza();

            // act
            bool actual = pizza.IsSize(new PersonalSize());

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizza_WhenAskingIfPersonalSize_ThenItShouldReturnTrue()
        {
            // arrange
            PersonalSize size = new PersonalSize();
            IProduct pizza = new Pizza(size);

            // act
            bool actual = pizza.IsSize(size);

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenDefaultPizza_WhenAskingIfFamilySize_ThenItShouldReturnFalse()
        {
            // arrange
            IProduct pizza = new Pizza();

            // act
            bool actual = pizza.IsSize(new FamilySize());

            // assert
            actual.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFamilySizePizza_WhenAskingIfFamilySize_ThenItShouldReturnTrue()
        {
            // arrange
            FamilySize sizeName = new FamilySize();
            IProduct pizza = new Pizza(sizeName);

            // act
            bool actual = pizza.IsSize(sizeName);

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFamilySizePizza_WhenAskingIfPersonalSize_ThenItShouldReturnFalse()
        {
            // arrange
            FamilySize sizeName = new FamilySize();
            IProduct pizza = new Pizza(sizeName);

            // act
            bool actual = pizza.IsSize(new PersonalSize());

            // assert
            actual.Should().BeFalse();
        }
    }
}