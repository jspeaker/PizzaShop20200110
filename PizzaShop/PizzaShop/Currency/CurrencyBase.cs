using System.Globalization;
using PizzaShop.PrimitiveConcepts;

namespace PizzaShop.Currency
{
    public abstract class CurrencyBase : ICurrency
    {
        private readonly Money _money;
        private readonly decimal _exchangeRate;
        private readonly CultureInfo _culture;

        protected CurrencyBase(Money money, decimal exchangeRate, CultureInfo culture)
        {
            _money = money;
            _exchangeRate = exchangeRate;
            _culture = culture;
        }

        private decimal ExchangeValue() => _money * _exchangeRate;

        public Text Formatted() => new FormattedMoney(ExchangeValue().ToString("C", _culture));
    }
}