using PizzaShop.Prices;
using PizzaShop.Sizes.Texts;

namespace PizzaShop.Sizes
{
    public class PersonalSize : ProductSize
    {
        public PersonalSize() : base(new PersonalSizeName(), new PersonalSizePizzaPrice()) { }
    }
}