using PizzaShop.Ingredients.Meat.Texts;
using PizzaShop.Location;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Meat
{
    public class CrispyHam : MeatIngredient
    {
        public CrispyHam(IProduct product) : base(product, new CrispyHamName()) { }

        public override bool IsAvailableAt(ILocation location) => location.IsLocation(LocationName.Springfield);
    }
}