using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Ingredients;
using PizzaShop.Ingredients.Meat;
using PizzaShop.Ingredients.Standard;
using PizzaShop.Products;
using PizzaShop.Sizes;

namespace PizzaShop.Unit.Tests.Products
{
    [TestClass]
    public class CalzoneDescriptionTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenDefaultCalzone_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct calzone = new Calzone();

            // act
            string actual = calzone.Description();

            // assert
            actual.Should().Be("Full Calzone");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFullSizeCalzone_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct calzone = new Calzone(new FullCalzoneSize());

            // act
            string actual = calzone.Description();

            // assert
            actual.Should().Be("Full Calzone");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenHalfSizeCalzone_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct calzone = new Calzone(new HalfCalzoneSize());

            // act
            string actual = calzone.Description();

            // assert
            actual.Should().Be("Half-Size Calzone");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFullSizeCalzoneWithMushrooms_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct calzone = new Calzone(new FullCalzoneSize(), new IIngredient[] { new Mushrooms(new Calzone(new FullCalzoneSize())) });

            // act
            string actual = calzone.Description();

            // assert
            actual.Should().Be("Full Calzone with Mushrooms");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFullSizeCalzoneWithMushroomsAndOlives_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            FullCalzoneSize size = new FullCalzoneSize();
            Calzone baseCalzone = new Calzone(size);
            IProduct calzone = new Calzone(size, new IIngredient[] { new Mushrooms(baseCalzone), new Olives(baseCalzone), });

            // act
            string actual = calzone.Description();

            // assert
            actual.Should().Be("Full Calzone with Mushrooms and Olives");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFullSizeCalzoneWithMushroomsBaconAndOlives_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            FullCalzoneSize size = new FullCalzoneSize();
            Calzone basePizza = new Calzone(size);
            IProduct calzone = new Calzone(size, new IIngredient[] { new Mushrooms(basePizza), new Bacon(basePizza), new Olives(basePizza) });

            // act
            string actual = calzone.Description();

            // assert
            actual.Should().Be("Full Calzone with Mushrooms, Bacon and Olives");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenHalfSizeCalzoneWithMushroomsBaconOlivesAndHam_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            HalfCalzoneSize size = new HalfCalzoneSize();
            Calzone baseCalzone = new Calzone(size);
            IProduct calzone = new Calzone(size, new IIngredient[] { new Mushrooms(baseCalzone), new Bacon(baseCalzone), new Olives(baseCalzone), new Ham(baseCalzone) });

            // act
            string actual = calzone.Description();

            // assert
            actual.Should().Be("Half-Size Calzone with Mushrooms, Bacon, Olives and Ham");
        }
    }
}
