using PizzaShop.Prices;
using PizzaShop.Sizes.Texts;

namespace PizzaShop.Sizes
{
    public class MediumSize : ProductSize
    {
        public MediumSize() : base(new MediumSizeName(), new MediumSizePizzaPrice()) { }
    }
}