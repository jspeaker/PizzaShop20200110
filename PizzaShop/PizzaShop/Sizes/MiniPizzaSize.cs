using PizzaShop.Prices;
using PizzaShop.Sizes.Texts;

namespace PizzaShop.Sizes
{
    public class MiniPizzaSize : ProductSize
    {
        public MiniPizzaSize() : base(new MiniSizeName(), new PersonalSizePizzaPrice()) { }
    }
}