using PizzaShop.Ingredients.Standard.Texts;
using PizzaShop.Location;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Standard
{
    public class AsiagoCheese : StandardIngredient
    {
        public AsiagoCheese(IProduct product) : base(product, new AsiagoCheeseName()) { }

        public override bool IsAvailableAt(ILocation location) => location.IsLocation(LocationName.Springfield);
    }
}