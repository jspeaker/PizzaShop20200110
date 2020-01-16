using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Controllers.Request;

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
            string invoice = order.Invoice();

            // assert
            invoice.Should().Be("Half-Size Calzone with Mushrooms and Pepperoni\n$10.00");
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
            string invoice = order.Invoice();

            // assert
            invoice.Should().Be("Half-Size Calzone with Pepperoni\n$9.20");
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
            string invoice = order.Invoice();

            // assert
            invoice.Should().Be("Full Calzone with Pepperoni\n$16.10");
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
            string invoice = order.Invoice();

            // assert
            invoice.Should().Be("Medium Pizza with Pepperoni\n$13.80");
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
            string invoice = order.Invoice();

            // assert
            invoice.Should().Be("Personal Pizza with Mushrooms and Pepperoni\n$11.25");
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
            string invoice = order.Invoice();

            // assert
            invoice.Should().Be("Personal Pizza with Pepperoni\n$10.35");
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
            string invoice = order.Invoice();

            // assert
            invoice.Should().Be("Personal Pizza with Pepperoni\n18,11 &");
        }
    }
}