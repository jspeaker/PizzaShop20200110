using PizzaShop.PrimitiveConcepts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Premium
{
    public class FetaCheese : PremiumIngredient
    {
        public FetaCheese(IProduct product) : base(product, new FetaCheeseName()) { }
    }

    public class FetaCheeseName : Text
    {
        public FetaCheeseName() : base("Feta Cheese") { }
    }
}