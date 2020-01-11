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
    public class ProductPriceTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenDefaultPizza_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza();

            // act
            decimal actual = pizza.Price();

            // assert
            actual.Should().Be(9.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizza_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new PersonalSize());

            // act
            decimal actual = pizza.Price();

            // assert
            actual.Should().Be(9.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFamilySizePizza_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new FamilySize());

            // act
            decimal actual = pizza.Price();

            // assert
            actual.Should().Be(18.0m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizzaWithOneStandardIngredient_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new PersonalSize(), new IIngredient[]
            {
                new Mushrooms(new Pizza(new PersonalSize()))
            });

            // act
            decimal actual = pizza.Price();

            // assert
            actual.Should().Be(9.9m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFamilySizePizzaWithOneStandardIngredient_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new FamilySize(), new IIngredient[]
            {
                new Mushrooms(new Pizza(new FamilySize()))
            });

            // act
            decimal actual = pizza.Price();

            // assert
            actual.Should().Be(19.8m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizzaWithTwoStandardIngredients_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new PersonalSize(), new IIngredient[]
            {
                new Mushrooms(new Pizza(new PersonalSize())),
                new Olives(new Pizza(new PersonalSize()))
            });

            // act
            decimal actual = pizza.Price();

            // assert
            actual.Should().Be(10.8m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFamilySizePizzaWithTwoStandardIngredients_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new FamilySize(), new IIngredient[]
            {
                new Mushrooms(new Pizza(new FamilySize())),
                new Olives(new Pizza(new FamilySize()))
            });

            // act
            decimal actual = pizza.Price();

            // assert
            actual.Should().Be(21.6m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizzaWithTwoStandardIngredientsAndTwoMeatIngredients_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new PersonalSize(), new IIngredient[]
            {
                new Mushrooms(new Pizza(new PersonalSize())),
                new Olives(new Pizza(new PersonalSize())),
                new Bacon(new Pizza(new PersonalSize())), 
                new Ham(new Pizza(new PersonalSize()))
            });

            // act
            decimal actual = pizza.Price();

            // assert
            actual.Should().Be(13.5m);
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFamilySizePizzaWithTwoStandardIngredientsAAndTwoMeatIngredients_WhenAskingForPrice_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new FamilySize(), new IIngredient[]
            {
                new Mushrooms(new Pizza(new FamilySize())),
                new Olives(new Pizza(new FamilySize())),
                new Bacon(new Pizza(new FamilySize())),
                new Ham(new Pizza(new FamilySize()))
            });

            // act
            decimal actual = pizza.Price();

            // assert
            actual.Should().Be(27.0m);
        }
    }
}