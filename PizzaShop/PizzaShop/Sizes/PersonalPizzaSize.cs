using PizzaShop.Prices;
using PizzaShop.Sizes.Texts;

namespace PizzaShop.Sizes
{
    public class PersonalPizzaSize : ProductSize
    {
        public PersonalPizzaSize() : base(new PersonalSizeName(), new PersonalSizePizzaPrice()) { }
    }
}