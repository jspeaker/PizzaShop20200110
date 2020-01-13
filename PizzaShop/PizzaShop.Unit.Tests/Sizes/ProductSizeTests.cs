using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Sizes;

namespace PizzaShop.Unit.Tests.Sizes
{
    [TestClass]
    public class ProductSizeTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenHalfCalzoneSize_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new HalfCalzoneSize();

            // act
            decimal actual = size.Price();

            // assert
            actual.Should().Be(8.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenHalfCalzoneSize_WhenAskingForName_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new HalfCalzoneSize();

            // act
            string actual = size.ToString();

            // assert
            actual.Should().Be("Half-Size");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFullCalzoneSize_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new FullCalzoneSize();

            // act
            decimal actual = size.Price();

            // assert
            actual.Should().Be(14.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFullCalzoneSize_WhenAskingForName_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new FullCalzoneSize();

            // act
            string actual = size.ToString();

            // assert
            actual.Should().Be("Full");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalPizzaSize_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new PersonalPizzaSize();

            // act
            decimal actual = size.Price();

            // assert
            actual.Should().Be(9.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalPizzaSize_WhenAskingForName_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new PersonalPizzaSize();

            // act
            string actual = size.ToString();

            // assert
            actual.Should().Be("Personal");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenMediumPizzaSize_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new MediumPizzaSize();

            // act
            decimal actual = size.Price();

            // assert
            actual.Should().Be(12.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenMediumPizzaSize_WhenAskingForName_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new MediumPizzaSize();

            // act
            string actual = size.ToString();

            // assert
            actual.Should().Be("Medium");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenLargePizzaSize_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new LargePizzaSize();

            // act
            decimal actual = size.Price();

            // assert
            actual.Should().Be(18.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenLargePizzaSize_WhenAskingForName_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProductSize size = new LargePizzaSize();

            // act
            string actual = size.ToString();

            // assert
            actual.Should().Be("Large");
        }
    }
}