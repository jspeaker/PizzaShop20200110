using PizzaShop.Ingredients;
using PizzaShop.Products.Descriptions;
using PizzaShop.Sizes;

namespace PizzaShop.Products
{
    public class Calzone : Product
    {
        public Calzone() : this(new FullCalzoneSize()) { }

        public Calzone(IProductSize size) : this(size, new IIngredient[0]) { }

        public Calzone(IProductSize size, IIngredient[] ingredients) : base(size, ingredients, new CalzoneProductName()) { }
    }
}