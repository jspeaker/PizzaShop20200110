using PizzaShop.Prices;
using PizzaShop.Sizes.Texts;

namespace PizzaShop.Sizes
{
    public class LargePizzaSize : ProductSize
    {
        public LargePizzaSize() : base(new LargeSizeName(), new LargeSizePizzaPrice()) { }
    }
}