using PizzaShop.Prices;
using PizzaShop.Sizes.Texts;

namespace PizzaShop.Sizes
{
    public class MediumPizzaSize : ProductSize
    {
        public MediumPizzaSize() : base(new MediumSizeName(), new MediumSizePizzaPrice()) { }
    }
}