using System.Globalization;
using PizzaShop.PrimitiveConcepts;

namespace PizzaShop.Currency
{
    public class LzyCurrency : CurrencyBase
    {
        public LzyCurrency(Money money) : this(money, 1.0m, new CultureInfo("en-US")) { }

        private LzyCurrency(Money money, decimal exchangeRate, CultureInfo culture) : base(money, exchangeRate, culture) { }
    }
}