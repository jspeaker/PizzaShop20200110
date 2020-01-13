using PizzaShop.Ingredients;
using PizzaShop.Products.Descriptions;
using PizzaShop.Sizes;

namespace PizzaShop.Products
{
    public class Pizza : Product
    {
        public Pizza() : this(new PersonalPizzaSize()) { }

        public Pizza(IProductSize size) : this(size, new IIngredient[0]) { }

        public Pizza(IProductSize size, IIngredient[] ingredients) : base(size, ingredients, new PizzaProductName()) { }
    }
}