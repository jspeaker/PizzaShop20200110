using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Sizes;

namespace PizzaShop.Unit.Tests.Sizes
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
            actual.Should().Be("Personal");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenMediumSize_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new MediumSize();

            // act
            decimal actual = size.Price();

            // assert
            actual.Should().Be(12.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenMediumSize_WhenAskingForName_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new MediumSize();

            // act
            string actual = size.ToString();

            // assert
            actual.Should().Be("Medium");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenLargeSize_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new LargeSize();

            // act
            decimal actual = size.Price();

            // assert
            actual.Should().Be(18.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenLargeSize_WhenAskingForName_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new LargeSize();

            // act
            string actual = size.ToString();

            // assert
            actual.Should().Be("Large");
        }
    }
}