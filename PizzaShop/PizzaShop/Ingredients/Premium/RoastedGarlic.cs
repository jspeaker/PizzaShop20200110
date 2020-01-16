using PizzaShop.Franchise;
using PizzaShop.Ingredients.Premium.Texts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Premium
{
    public class RoastedGarlic : PremiumIngredient
    {
        public RoastedGarlic(IProduct product) : base(product, new RoastedGarlicName()) { }

        public override bool IsAvailableAt(LocationName locationName) => locationName != LocationName.Springfield;
    }
}