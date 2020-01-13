using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Sizes;
using PizzaShop.Sizes.Mapping;

namespace PizzaShop.Unit.Tests.Sizes.Mapping
{
    [TestClass]
    public class SizeMapTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenFullSizeName_WhenAskingToMap_ThenItShouldReturnCorrectSize()
        {
            // arrange
            const string name = "Full";
            SizeMap sizeMap = new SizeMap();

            // act
            IProductSize mappedSize = sizeMap.DomainSize(name);

            // assert
            ((decimal)mappedSize.Price()).Should().Be(14.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenHalfSizeName_WhenAskingToMap_ThenItShouldReturnCorrectSize()
        {
            // arrange
            const string name = "Half-Size";
            SizeMap sizeMap = new SizeMap();

            // act
            IProductSize mappedSize = sizeMap.DomainSize(name);

            // assert
            ((decimal)mappedSize.Price()).Should().Be(8.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizeName_WhenAskingToMap_ThenItShouldReturnCorrectSize()
        {
            // arrange
            const string name = "Personal";
            SizeMap sizeMap = new SizeMap();

            // act
            IProductSize mappedSize = sizeMap.DomainSize(name);

            // assert
            ((decimal)mappedSize.Price()).Should().Be(9.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenMediumSizeName_WhenAskingToMap_ThenItShouldReturnCorrectSize()
        {
            // arrange
            const string name = "Medium";
            SizeMap sizeMap = new SizeMap();

            // act
            IProductSize mappedSize = sizeMap.DomainSize(name);

            // assert
            ((decimal)mappedSize.Price()).Should().Be(12.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenLargeSizeName_WhenAskingToMap_ThenItShouldReturnCorrectSize()
        {
            // arrange
            const string name = "Large";
            SizeMap sizeMap = new SizeMap();

            // act
            IProductSize mappedSize = sizeMap.DomainSize(name);

            // assert
            ((decimal)mappedSize.Price()).Should().Be(18.0m);
        }
    }
}