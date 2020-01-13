using PizzaShop.Prices;
using PizzaShop.Sizes.Texts;

namespace PizzaShop.Sizes
{
    public class LargeSize : ProductSize
    {
        public LargeSize() : base(new LargeSizeName(), new LargeSizePizzaPrice()) { }
    }
}