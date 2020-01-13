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
            invoice.Should().Be("Half-Size Calzone with Mushrooms and Pepperoni\n10.000");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenHalfSizeCalzoneAndChangedIngredients_WhenAskingForInvoice_ThenItShouldReturnCorrectInvoice()
        {
            // arrange
            Order order = new Order
            {
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
            invoice.Should().Be("Half-Size Calzone with Pepperoni\n9.200");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizza_WhenAskingForInvoice_ThenItShouldReturnCorrectInvoice()
        {
            // arrange
            Order order = new Order
            {
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
            invoice.Should().Be("Personal Pizza with Mushrooms and Pepperoni\n11.250");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenPersonalSizePizzaAndChangedIngredients_WhenAskingForInvoice_ThenItShouldReturnCorrectInvoice()
        {
            // arrange
            Order order = new Order
            {
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
            invoice.Should().Be("Personal Pizza with Pepperoni\n10.350");
        }
    }
}