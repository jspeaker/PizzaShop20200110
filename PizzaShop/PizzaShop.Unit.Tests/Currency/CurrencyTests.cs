using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Currency;
using PizzaShop.PrimitiveConcepts;

namespace PizzaShop.Unit.Tests.Currency
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenLzyCurrency_WhenAskingForFormattedText_ThenItShouldReturnCorrectValue()
        {
            // arrange
            ICurrency baseCurrency = new LzyCurrency(new CalculatedMoney(1235.5m));

            // act
            Text actual = baseCurrency.Formatted();

            // assert
            ((string) actual).Should().Be("$1,235.50");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenBlkCurrency_WhenAskingForFormattedText_ThenItShouldReturnCorrectValue()
        {
            // arrange
            ICurrency baseCurrency = new BlkCurrency(new CalculatedMoney(100.2m));

            // act
            Text actual = baseCurrency.Formatted();

            // assert
            ((string)actual).Should().Be("175,35 &");
        }
    }
}