using PizzaShop.Franchise;
using PizzaShop.PrimitiveConcepts;

namespace PizzaShop.Ingredients
{
    public abstract class Ingredient : IIngredient
    {
        private readonly Money _price;
        private readonly Text _name;

        protected Ingredient(Money price, Text name)
        {
            _price = price;
            _name = name;
        }

        public Money Price() => _price;

        public Text Name() => _name;

        public virtual bool IsAvailableAt(LocationName locationName) => true;

        public int CompareTo(object obj)
        {
            if (_price > ((IIngredient) obj).Price()) return 1;
            if (_price < ((IIngredient) obj).Price()) return -1;
            return 0;
        }
    }
}