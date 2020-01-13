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
    public class ProductDescriptionTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenDefaultPizza_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza();

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Pizza");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizza_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new PersonalSize());

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Pizza");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenMediumSizePizza_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new MediumSize());

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Pizza");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenLargeSizePizza_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new LargeSize());

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Pizza");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizzaWithMushrooms_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new PersonalSize(), new IIngredient[] { new Mushrooms(new Pizza(new PersonalSize())) });

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Pizza with mushrooms");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizzaWithMushroomsAndOlives_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            PersonalSize size = new PersonalSize();
            Pizza basePizza = new Pizza(size);
            IProduct pizza = new Pizza(size, new IIngredient[] { new Mushrooms(basePizza), new Olives(basePizza),  });

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Pizza with mushrooms, olives");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizzaWithMushroomsBaconAndOlives_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            PersonalSize size = new PersonalSize();
            Pizza basePizza = new Pizza(size);
            IProduct pizza = new Pizza(size, new IIngredient[] { new Mushrooms(basePizza), new Bacon(basePizza), new Olives(basePizza) });

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Pizza with mushrooms, bacon, olives");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenMediumSizePizzaWithMushroomsBaconOlivesAndHam_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            MediumSize size = new MediumSize();
            Pizza basePizza = new Pizza(size);
            IProduct pizza = new Pizza(size, new IIngredient[] { new Mushrooms(basePizza), new Bacon(basePizza), new Olives(basePizza), new Ham(basePizza)  });

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Pizza with mushrooms, bacon, olives, ham");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenLargeSizePizzaWithMushroomsBaconOlivesAndHam_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            LargeSize size = new LargeSize();
            Pizza basePizza = new Pizza(size);
            IProduct pizza = new Pizza(size, new IIngredient[] { new Mushrooms(basePizza), new Bacon(basePizza), new Olives(basePizza), new Ham(basePizza)  });

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Pizza with mushrooms, bacon, olives, ham");
        }
    }
}
