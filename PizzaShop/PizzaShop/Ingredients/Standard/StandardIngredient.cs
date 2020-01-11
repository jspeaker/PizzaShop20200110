using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Standard
{
    public abstract class StandardIngredient : IIngredient
    {
        private readonly Money _price;
        private readonly Text _name;

        protected StandardIngredient(IProduct product, Text name) : this(new CalculatedMoney(product.Price() * .1m), name) { }

        private StandardIngredient(Money price, Text name)
        {
            _price = price;
            _name = name;
        }

        public Money Price() => _price;
        public Text Name() => _name;
    }
}