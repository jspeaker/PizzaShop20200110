using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Controllers.Request;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PizzaShop.Unit.Tests.Controllers.Request
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenHalfSizeCalzone_WhenAskingForInvoice_ThenItShouldReturnCorrectInvoice()
        {
            // arrange
            Order order = new Order
            {
                Location = "Bedrock",
                Products = new []
                {
                    new ProductRequest
                    {
                        Name = "Calzone",
                        Size = "Half-Size",
                        Ingredients = new []
                        {
                            "Mushrooms",
                            "Pepperoni"
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
            privateer.Field<string>(lineItems[0], "_description").Should().Be("Half-Size Calzone with Mushrooms and Pepperoni");
            privateer.Field<string>(lineItems[0], "_price").Should().Be("$10.00");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenHalfSizeCalzoneWithChangedIngredients_WhenAskingForInvoice_ThenItShouldReturnCorrectInvoice()
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
                            "Mushrooms",
                            "Pepperoni"
                        }
                    }
                }
            };

            order.Products = new[]
            {
                new ProductRequest
                {
                    Name = "Calzone",
                    Size = "Half-Size",
                    Ingredients = new[]
                    {
                        "Pepperoni"
                    }
                }
            };

            // act
            Invoice invoice = order.Invoice();

            // assert
            Privateer privateer = new Privateer();
            List<LineItem> lineItems = privateer.Field<List<LineItem>>(invoice, "_lineItems");
            lineItems.Should().HaveCount(1);
            privateer.Field<string>(lineItems[0], "_description").Should().Be("Half-Size Calzone with Pepperoni");
            privateer.Field<string>(lineItems[0], "_price").Should().Be("$9.20");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenHalfSizeCalzoneWithChangedSizeAndIngredients_WhenAskingForInvoice_ThenItShouldReturnCorrectInvoice()
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
                            "Mushrooms",
                            "Pepperoni"
                        }
                    }
                }
            };

            order.Products = new[]
            {
                new ProductRequest
                {
                    Name = "Calzone",
                    Size = "Full",
                    Ingredients = new[]
                    {
                        "Pepperoni"
                    }
                }
            };

            // act
            Invoice invoice = order.Invoice();

            // assert
            Privateer privateer = new Privateer();
            List<LineItem> lineItems = privateer.Field<List<LineItem>>(invoice, "_lineItems");
            lineItems.Should().HaveCount(1);
            privateer.Field<string>(lineItems[0], "_description").Should().Be("Full Calzone with Pepperoni");
            privateer.Field<string>(lineItems[0], "_price").Should().Be("$16.10");
        }


        [TestMethod, TestCategory("Unit")]
        public void GivenHalfSizeCalzoneWithChangedProductIngredientsAndSize_WhenAskingForInvoice_ThenItShouldReturnCorrectInvoice()
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
                            "Mushrooms",
                            "Pepperoni"
                        }
                    }
                }
            };

            order.Products = new[]
            {
                new ProductRequest
                {
                    Name = "Pizza",
                    Size = "Medium",
                    Ingredients = new[]
                    {
                        "Pepperoni"
                    }
                }
            };

            // act
            Invoice invoice = order.Invoice();

            // assert
            Privateer privateer = new Privateer();
            List<LineItem> lineItems = privateer.Field<List<LineItem>>(invoice, "_lineItems");
            lineItems.Should().HaveCount(1);
            privateer.Field<string>(lineItems[0], "_description").Should().Be("Medium Pizza with Pepperoni");
            privateer.Field<string>(lineItems[0], "_price").Should().Be("$13.80");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizza_WhenAskingForInvoice_ThenItShouldReturnCorrectInvoice()
        {
            // arrange
            Order order = new Order
            {
                Location = "Bedrock",
                Products = new []
                {
                    new ProductRequest
                    {
                        Name = "Pizza",
                        Size = "Personal",
                        Ingredients = new []
                        {
                            "Mushrooms",
                            "Pepperoni"
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
            privateer.Field<string>(lineItems[0], "_description").Should().Be("Personal Pizza with Mushrooms and Pepperoni");
            privateer.Field<string>(lineItems[0], "_price").Should().Be("$11.25");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizzaAndChangedIngredients_WhenAskingForInvoice_ThenItShouldReturnCorrectInvoice()
        {
            // arrange
            Order order = new Order
            {
                Location = "Bedrock",
                Products = new []
                {
                    new ProductRequest
                    {
                        Name = "Pizza",
                        Size = "Personal",
                        Ingredients = new []
                        {
                            "Mushrooms",
                            "Pepperoni"
                        }
                    }
                }
            };

            order.Products = new[]
            {
                new ProductRequest
                {
                    Name = "Pizza",
                    Size = "Personal",
                    Ingredients = new[]
                    {
                        "Pepperoni"
                    }
                }
            };

            // act
            Invoice invoice = order.Invoice();

            // assert
            Privateer privateer = new Privateer();
            List<LineItem> lineItems = privateer.Field<List<LineItem>>(invoice, "_lineItems");
            lineItems.Should().HaveCount(1);
            privateer.Field<string>(lineItems[0], "_description").Should().Be("Personal Pizza with Pepperoni");
            privateer.Field<string>(lineItems[0], "_price").Should().Be("$10.35");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenBricksburgLocationPersonalSizePizzaAndChangedIngredients_WhenAskingForInvoice_ThenItShouldReturnCorrectInvoice()
        {
            // arrange
            Order order = new Order
            {
                Location = "Bricksburg",
                Products = new []
                {
                    new ProductRequest
                    {
                        Name = "Pizza",
                        Size = "Personal",
                        Ingredients = new []
                        {
                            "Mushrooms",
                            "Pepperoni"
                        }
                    }
                }
            };

            order.Products = new[]
            {
                new ProductRequest
                {
                    Name = "Pizza",
                    Size = "Personal",
                    Ingredients = new[]
                    {
                        "Pepperoni"
                    }
                }
            };

            // act
            Invoice invoice = order.Invoice();

            // assert
            Privateer privateer = new Privateer();
            List<LineItem> lineItems = privateer.Field<List<LineItem>>(invoice, "_lineItems");
            lineItems.Should().HaveCount(1);
            privateer.Field<string>(lineItems[0], "_description").Should().Be("Personal Pizza with Pepperoni");
            privateer.Field<string>(lineItems[0], "_price").Should().Be("18,11 &");

            string serializedInvoice = JsonConvert.SerializeObject(invoice);
        }
    }
}