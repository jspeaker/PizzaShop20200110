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
    public class CalzonePriceTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenDefaultCalzone_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct calzone = new Calzone();

            // act
            decimal actual = calzone.Price();

            // assert
            actual.Should().Be(14.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFullSizeCalzone_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct calzone = new Calzone(new FullCalzoneSize());

            // act
            decimal actual = calzone.Price();

            // assert
            actual.Should().Be(14.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenHalfSizeCalzone_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct calzone = new Calzone(new HalfCalzoneSize());

            // act
            decimal actual = calzone.Price();

            // assert
            actual.Should().Be(8.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenHalfSizeCalzoneWithOneStandardIngredient_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct calzone = new Calzone(new HalfCalzoneSize(), new IIngredient[]
            {
                new Mushrooms(new Calzone(new HalfCalzoneSize()))
            });

            // act
            decimal actual = calzone.Price();

            // assert
            actual.Should().Be(8.8m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFullSizeCalzoneWithOneStandardIngredient_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct calzone = new Calzone(new FullCalzoneSize(), new IIngredient[]
            {
                new Mushrooms(new Calzone(new FullCalzoneSize()))
            });

            // act
            decimal actual = calzone.Price();

            // assert
            actual.Should().Be(15.4m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenHalfSizeCalzoneWithTwoStandardIngredients_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct calzone = new Calzone(new HalfCalzoneSize(), new IIngredient[]
            {
                new Mushrooms(new Calzone(new HalfCalzoneSize())),
                new Olives(new Calzone(new HalfCalzoneSize()))
            });

            // act
            decimal actual = calzone.Price();

            // assert
            actual.Should().Be(9.6m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFullSizeCalzoneWithTwoStandardIngredients_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct calzone = new Calzone(new FullCalzoneSize(), new IIngredient[]
            {
                new Mushrooms(new Calzone(new FullCalzoneSize())),
                new Olives(new Calzone(new FullCalzoneSize()))
            });

            // act
            decimal actual = calzone.Price();

            // assert
            actual.Should().Be(16.8m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenHalfSizeCalzoneWithTwoStandardIngredientsAndTwoMeatIngredients_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct calzone = new Calzone(new HalfCalzoneSize(), new IIngredient[]
            {
                new Mushrooms(new Calzone(new HalfCalzoneSize())),
                new Olives(new Calzone(new HalfCalzoneSize())),
                new Bacon(new Calzone(new HalfCalzoneSize())),
                new Ham(new Calzone(new HalfCalzoneSize()))
            });

            // act
            decimal actual = calzone.Price();

            // assert
            actual.Should().Be(12.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFullSizeCalzoneWithTwoStandardIngredientsAAndTwoMeatIngredients_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct calzone = new Calzone(new FullCalzoneSize(), new IIngredient[]
            {
                new Mushrooms(new Calzone(new FullCalzoneSize())),
                new Olives(new Calzone(new FullCalzoneSize())),
                new Bacon(new Calzone(new FullCalzoneSize())),
                new Ham(new Calzone(new FullCalzoneSize()))
            });

            // act
            decimal actual = calzone.Price();

            // assert
            actual.Should().Be(21.0m);
        }
    }
}