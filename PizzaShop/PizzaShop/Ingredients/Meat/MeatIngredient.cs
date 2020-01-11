using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Meat
{
    public abstract class MeatIngredient : IIngredient
    {
        private readonly Money _price;
        private readonly Text _name;

        protected MeatIngredient(IProduct product, Text name) : this(new CalculatedMoney(product.Price() * .15m), name) { }

        private MeatIngredient(Money price, Text name)
        {
            _price = price;
            _name = name;
        }

        public Money Price() => _price;
        public Text Name() => _name;
    }
}