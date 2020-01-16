using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Controllers.Request;
using System;
using System.Collections.Generic;

namespace PizzaShop.Unit.Tests.Controllers.Request
{
    [TestClass]
    public class OrderLocationTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenSpringfieldLocation_WhenAskingForMiniSizePizza_ThenItShouldReturnCorrectValue()
        {
            // arrange
            Order order = new Order
            {
                Location = "Springfield",
                Products = new[]
                {
                    new ProductRequest
                    {
                        Name = "Pizza",
                        Size = "Mini",
                        Ingredients = new []
                        {
                            "Mushrooms"
                        }
                    }
                }
            };

            // act
            Invoice invoice = order.Invoice();

            // assert
            Privateer privateer = new Privateer();
            List<LineItem> lineItems = privateer.Field<List<LineItem>>(invoice, "_lineItems");
            lineItems.Should().HaveCount(1);
            privateer.Field<string>(lineItems[0], "_description").Should().Be("Mini Pizza with Mushrooms");
            privateer.Field<string>(lineItems[0], "_price").Should().Be("$9.90");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenBedrockLocation_WhenAskingForMiniSizePizza_ThenItShouldReturnCorrectValue()
        {
            // arrange
            Order order = new Order
            {
                Location = "Bedrock",
                Products = new[]
                {
                    new ProductRequest
                    {
                        Name = "Pizza",
                        Size = "Personal",
                        Ingredients = new []
                        {
                            "Mushrooms"
                        }
                    }
                }
            };

            // act
            Invoice invoice = order.Invoice();

            // assert
            Privateer privateer = new Privateer();
            List<LineItem> lineItems = privateer.Field<List<LineItem>>(invoice, "_lineItems");
            lineItems.Should().HaveCount(1);
            privateer.Field<string>(lineItems[0], "_description").Should().Be("Personal Pizza with Mushrooms");
            privateer.Field<string>(lineItems[0], "_price").Should().Be("$9.90");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenBricksburgLocation_WhenAskingForMiniSizePizza_ThenItShouldReturnCorrectValue()
        {
            // arrange
            Order order = new Order
            {
                Location = "Bricksburg",
                Products = new[]
                {
                    new ProductRequest
                    {
                        Name = "Pizza",
                        Size = "Personal",
                        Ingredients = new []
                        {
                            "Mushrooms"
                        }
                    }
                }
            };

            // act
            Invoice invoice = order.Invoice();

            // assert
            Privateer privateer = new Privateer();
            List<LineItem> lineItems = privateer.Field<List<LineItem>>(invoice, "_lineItems");
            lineItems.Should().HaveCount(1);
            privateer.Field<string>(lineItems[0], "_description").Should().Be("Personal Pizza with Mushrooms");
            privateer.Field<string>(lineItems[0], "_price").Should().Be("17,33 &");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenSpringfieldLocation_WhenAskingForMiniSizePizzaWithCrispyHam_ThenItShouldReturnCorrectValue()
        {
            // arrange
            Order order = new Order
            {
                Location = "Springfield",
                Products = new[]
                {
                    new ProductRequest
                    {
                        Name = "Pizza",
                        Size = "Mini",
                        Ingredients = new []
                        {
                            "Crispy Ham"
                        }
                    }
                }
            };

            // act
            Invoice invoice = order.Invoice();

            // assert
            Privateer privateer = new Privateer();
            List<LineItem> lineItems = privateer.Field<List<LineItem>>(invoice, "_lineItems");
            lineItems.Should().HaveCount(1);
            privateer.Field<string>(lineItems[0], "_description").Should().Be("Mini Pizza with Crispy Ham");
            privateer.Field<string>(lineItems[0], "_price").Should().Be("$10.35");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenSpringfieldLocation_WhenAskingForMiniSizePizza_ThenItShouldNotThrow()
        {
            // arrange
            Order order = new Order
            {
                Location = "Springfield",
                Products = new[]
                {
                    new ProductRequest
                    {
                        Name = "Calzone",
                        Size = "Mini",
                        Ingredients = new []
                        {
                            "Mushrooms"
                        }
                    }
                }
            };

            // act
            Action action = () => order.Invoice();

            // assert
            action.Should().NotThrow<Exception>();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenSpringfieldLocation_WhenAskingForRoastedGarlic_ThenItShouldThrow()
        {
            // arrange
            Order order = new Order
            {
                Location = "Springfield",
                Products = new[]
                {
                    new ProductRequest
                    {
                        Name = "Calzone",
                        Size = "Half-Size",
                        Ingredients = new []
                        {
                            "Roasted Garlic"
                        }
                    }
                }
            };

            // act
            Action action = () => order.Invoice();

            // assert
            action.Should().Throw<Exception>();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenBedrockLocation_WhenAskingForRoastedGarlic_ThenItShouldNotThrow()
        {
            // arrange
            Order order = new Order
            {
                Location = "Bedrock",
                Products = new[]
                {
                    new ProductRequest
                    {
                        Name = "Calzone",
                        Size = "Half-Size",
                        Ingredients = new []
                        {
                            "Roasted Garlic"
                        }
                    }
                }
            };

            // act
            Action action = () => order.Invoice();

            // assert
            action.Should().NotThrow<Exception>();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenBedrockLocation_WhenAskingForAsiagoCheese_ThenItShouldThrow()
        {
            // arrange
            Order order = new Order
            {
                Location = "Bedrock",
                Products = new[]
                {
                    new ProductRequest
                    {
                        Name = "Calzone",
                        Size = "Half-Size",
                        Ingredients = new []
                        {
                            "Asiago Cheese"
                        }
                    }
                }
            };

            // act
            Action action = () => order.Invoice();

            // assert
            action.Should().Throw<Exception>();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenSpringfieldLocation_WhenAskingForAsiagoCheese_ThenItShouldNotThrow()
        {
            // arrange
            Order order = new Order
            {
                Location = "Springfield",
                Products = new[]
                {
                    new ProductRequest
                    {
                        Name = "Calzone",
                        Size = "Half-Size",
                        Ingredients = new []
                        {
                            "Asiago Cheese"
                        }
                    }
                }
            };

            // act
            Action action = () => order.Invoice();

            // assert
            action.Should().NotThrow<Exception>();
        }
    }
}