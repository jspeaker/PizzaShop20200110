using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Sizes;
using PizzaShop.Sizes.Mapping;
using System;

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
        public void GivenAlternativeSizeName_WhenAskingToMap_ThenItShouldReturnCorrectSize()
        {
            // arrange
            const string name = "Mini";
            SizeMap sizeMap = new SizeMap();

            // act
            IProductSize actual = sizeMap.DomainSize(name);

            // assert
            actual.GetType().Name.Should().Be(nameof(MiniPizzaSize));
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenNonExistentSizeName_WhenAskingToMap_ThenItShouldThrow()
        {
            // arrange
            const string name = "Dammit, Bobby!";
            SizeMap sizeMap = new SizeMap();

            // act
            Action action = () => sizeMap.DomainSize(name);

            // assert
            action.Should().Throw<Exception>();
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