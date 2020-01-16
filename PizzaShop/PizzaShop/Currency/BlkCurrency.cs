using System.Globalization;
using PizzaShop.PrimitiveConcepts;

namespace PizzaShop.Currency
{
    public class BlkCurrency : CurrencyBase
    {
        public BlkCurrency(Money money) : this(money, 1.75m, new CultureInfo("fr-FR") { NumberFormat = { CurrencySymbol = "&" } }) { }

        private BlkCurrency(Money money, decimal exchangeRate, CultureInfo culture) : base(money, exchangeRate, culture) { }
    }
}