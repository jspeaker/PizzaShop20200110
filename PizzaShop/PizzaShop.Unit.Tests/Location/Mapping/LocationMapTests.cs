using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Location;
using PizzaShop.Location.Mapping;

namespace PizzaShop.Unit.Tests.Location.Mapping
{
    [TestClass]
    public class LocationMapTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenRecognizedLocationName_WhenAskingForLocation_ThenItShouldReturnCorrectValue()
        {
            // arrange
            LocationMap locationMap = new LocationMap(LocationName.Bedrock);

            // act
            ILocation location = locationMap.DomainLocation();

            // assert
            location.Should().BeOfType<BedrockLocation>();
        }
    }
}