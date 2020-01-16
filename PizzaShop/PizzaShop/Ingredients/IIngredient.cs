using PizzaShop.PrimitiveConcepts;
using System;
using PizzaShop.Franchise;

namespace PizzaShop.Ingredients
{
    public interface IIngredient : IComparable
    {
        Money Price();
        Text Name();
        bool IsAvailableAt(LocationName locationName);
    }
}