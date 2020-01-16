using PizzaShop.Currency;
using PizzaShop.PrimitiveConcepts;
using System;

namespace PizzaShop.Location
{
    public abstract class Location<T> : ILocation where T : ICurrency
    {
        public Text LocalizedPrice(Money money) => ((ICurrency) Activator.CreateInstance(typeof(T), money)).Formatted();
        public virtual bool IsLocation(LocationName locationName) => false;
    }
}