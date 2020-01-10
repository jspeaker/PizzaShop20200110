using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Sizes;

namespace PizzaShop.Unit.Tests
{
    [TestClass]
    public class ProductSizeTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSize_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new PersonalSize();

            // act
            decimal actual = size.Price();

            // assert
            actual.Should().Be(9.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSize_WhenAskingForName_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new PersonalSize();

            // act
            string actual = size.ToString();

            // assert
            actual.Should().Be(new PersonalSizeName());
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFamilySize_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new FamilySize();

            // act
            decimal actual = size.Price();

            // assert
            actual.Should().Be(18.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFamilySize_WhenAskingForName_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new FamilySize();

            // act
            string actual = size.ToString();

            // assert
            actual.Should().Be(new FamilySizeName());
        }
    }
}