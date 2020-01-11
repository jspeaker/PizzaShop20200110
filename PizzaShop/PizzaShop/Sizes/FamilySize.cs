using PizzaShop.Prices;
using PizzaShop.Sizes.Texts;

namespace PizzaShop.Sizes
{
    public class FamilySize : ProductSize
    {
        public FamilySize() : base(new FamilySizeName(), new FamilySizePizzaPrice()) { }
    }
}