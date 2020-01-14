using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Ingredients;
using PizzaShop.Ingredients.Meat;
using PizzaShop.Ingredients.Premium;
using PizzaShop.Ingredients.Standard;
using PizzaShop.Products;
using PizzaShop.Sizes;

namespace PizzaShop.Unit.Tests.Products
{
    [TestClass]
    public class PizzaDescriptionTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenDefaultPizza_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza();

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Personal Pizza");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizza_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new PersonalPizzaSize());

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Personal Pizza");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenMediumSizePizza_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new MediumPizzaSize());

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Medium Pizza");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenLargeSizePizza_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new LargePizzaSize());

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Large Pizza");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizzaWithMushrooms_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new PersonalPizzaSize(), new IIngredient[] { new Mushrooms(new Pizza(new PersonalPizzaSize())) });

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Personal Pizza with Mushrooms");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizzaWithPepperoni_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new PersonalPizzaSize(), new IIngredient[] { new Pepperoni(new Pizza(new PersonalPizzaSize())) });

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Personal Pizza with Pepperoni");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizzaWithFetaCheese_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            IProduct pizza = new Pizza(new PersonalPizzaSize(), new IIngredient[] { new FetaCheese(new Pizza(new PersonalPizzaSize())),  });

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Personal Pizza with Feta Cheese");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizzaWithMushroomsAndOlives_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            PersonalPizzaSize pizzaSize = new PersonalPizzaSize();
            Pizza basePizza = new Pizza(pizzaSize);
            IProduct pizza = new Pizza(pizzaSize, new IIngredient[] { new Mushrooms(basePizza), new Olives(basePizza),  });

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Personal Pizza with Mushrooms and Olives");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizzaWithMushroomsBaconAndOlives_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            PersonalPizzaSize pizzaSize = new PersonalPizzaSize();
            Pizza basePizza = new Pizza(pizzaSize);
            IProduct pizza = new Pizza(pizzaSize, new IIngredient[] { new Mushrooms(basePizza), new Bacon(basePizza), new Olives(basePizza) });

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Personal Pizza with Mushrooms, Olives and Bacon");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenMediumSizePizzaWithMushroomsBaconOlivesAndHam_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            MediumPizzaSize pizzaSize = new MediumPizzaSize();
            Pizza basePizza = new Pizza(pizzaSize);
            IProduct pizza = new Pizza(pizzaSize, new IIngredient[] { new Mushrooms(basePizza), new Bacon(basePizza), new Olives(basePizza), new Ham(basePizza)  });

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Medium Pizza with Mushrooms, Olives, Bacon and Ham");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenLargeSizePizzaWithMushroomsBaconOlivesAndHam_WhenAskingForDescription_ThenItShouldReturnCorrectValue()
        {
            // arrange
            LargePizzaSize pizzaSize = new LargePizzaSize();
            Pizza basePizza = new Pizza(pizzaSize);
            IProduct pizza = new Pizza(pizzaSize, new IIngredient[] { new Mushrooms(basePizza), new Bacon(basePizza), new Olives(basePizza), new Ham(basePizza)  });

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Large Pizza with Mushrooms, Olives, Bacon and Ham");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenLargeSizePizzaWithStandardMetaAndPremiumIngredientsInWrongOrder_WhenAskingForDescription_ThenItShouldReturnProperlyOrderedDescription()
        {
            // arrange
            LargePizzaSize pizzaSize = new LargePizzaSize();
            Pizza basePizza = new Pizza(pizzaSize);
            IProduct pizza = new Pizza(pizzaSize, new IIngredient[] 
            { 
                new Bacon(basePizza),
                new RoastedGarlic(basePizza), 
                new Olives(basePizza),
                new Mushrooms(basePizza),
                new FetaCheese(basePizza), 
                new Ham(basePizza)
            });

            // act
            string actual = pizza.Description();

            // assert
            actual.Should().Be("Large Pizza with Olives, Mushrooms, Bacon, Ham, Roasted Garlic and Feta Cheese");
        }
    }
}
