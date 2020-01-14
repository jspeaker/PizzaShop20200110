using PizzaShop.PrimitiveConcepts;
using System;

namespace PizzaShop.Ingredients
{
    public interface IIngredient : IComparable
    {
        Money Price();
        Text Name();
    }
}