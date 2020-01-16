using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.PrimitiveConcepts;
using FluentAssertions;
using PizzaShop.Location;

namespace PizzaShop.Unit.Tests.Location
{
    [TestClass]
    public class LocationTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenBedrockLocation_WhenAskingForLocalizedPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            BedrockLocation location = new BedrockLocation();

            // act
            Text localizedPrice = location.LocalizedPrice(new CalculatedMoney(123.4m));

            // assert
            ((string) localizedPrice).Should().Be("$123.40");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenSpringfieldLocation_WhenAskingForLocalizedPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            SpringfieldLocation location = new SpringfieldLocation();

            // act
            Text localizedPrice = location.LocalizedPrice(new CalculatedMoney(123.4m));

            // assert
            ((string) localizedPrice).Should().Be("$123.40");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenBricksburgLocation_WhenAskingForLocalizedPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            BricksburgLocation location = new BricksburgLocation();

            // act
            Text localizedPrice = location.LocalizedPrice(new CalculatedMoney(123.4m));

            // assert
            ((string) localizedPrice).Should().Be("215,95 &");
        }
    }
}