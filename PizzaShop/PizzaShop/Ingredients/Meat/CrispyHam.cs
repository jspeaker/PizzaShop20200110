using PizzaShop.Franchise;
using PizzaShop.Ingredients.Meat.Texts;
using PizzaShop.Products;

namespace PizzaShop.Ingredients.Meat
{
    public class CrispyHam : MeatIngredient
    {
        public CrispyHam(IProduct product) : base(product, new CrispyHamName()) { }

        public override bool IsAvailableAt(Location location) => location == Location.ExpansionOne;
    }
}