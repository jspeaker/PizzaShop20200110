using PizzaShop.Prices;
using PizzaShop.PrimitiveConcepts;

namespace PizzaShop.Sizes
{
    public class PersonalSize : ProductSize
    {
        public PersonalSize() : base(new PersonalSizeName()) { }

        public override Money Price() => new PersonalSizePizzaPrice();
    }
}