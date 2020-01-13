using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Controllers.Request;

namespace PizzaShop.Unit.Tests.Controllers.Request
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizza_WhenAskingForInvoice_ThenItShouldReturnCorrectInvoice()
        {
            // arrange
            Order order = new Order
            {
                Pizzas = new []
                {
                    new PizzaRequest
                    {
                        Size = "Personal",
                        Ingredients = new []
                        {
                            "mushrooms",
                            "pepperoni"
                        }
                    }
                }
            };

            // act
            string invoice = order.Invoice();

            // assert
            invoice.Should().Be("Pizza with mushrooms, pepperoni\n11.250");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizzaAndChangedIngredients_WhenAskingForInvoice_ThenItShouldReturnCorrectInvoice()
        {
            // arrange
            Order order = new Order
            {
                Pizzas = new []
                {
                    new PizzaRequest
                    {
                        Size = "Personal",
                        Ingredients = new []
                        {
                            "mushrooms",
                            "pepperoni"
                        }
                    }
                }
            };

            order.Pizzas = new[]
            {
                new PizzaRequest
                {
                    Size = "Personal",
                    Ingredients = new[]
                    {
                        "pepperoni"
                    }
                }
            };

            // act
            string invoice = order.Invoice();

            // assert
            invoice.Should().Be("Pizza with pepperoni\n10.350");
        }
    }
}