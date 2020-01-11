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
            actual.Should().Be("Personal pizza");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizza_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new PersonalSize());

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Personal pizza");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFamilySizePizza_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new FamilySize());

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Family pizza");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizzaWithMushrooms_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new PersonalSize(), new IIngredient[] { new Mushrooms(new Pizza(new PersonalSize())) });

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Personal pizza with mushrooms");
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
            actual.Should().Be("Personal pizza with mushrooms, olives");
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
            actual.Should().Be("Personal pizza with mushrooms, bacon, olives");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenFamilySizePizzaWithMushroomsBaconOlivesAndHam_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            FamilySize size = new FamilySize();
            Pizza basePizza = new Pizza(size);
            IProduct pizza = new Pizza(size, new IIngredient[] { new Mushrooms(basePizza), new Bacon(basePizza), new Olives(basePizza), new Ham(basePizza)  });

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Family pizza with mushrooms, bacon, olives, ham");
        }
    }
}
