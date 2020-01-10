using PizzaShop.Prices;
using PizzaShop.PrimitiveConcepts;

namespace PizzaShop.Sizes
{
    public class FamilySize : ProductSize
    {
        public FamilySize() : base(new FamilySizeName()) { }

        public override Money Price() => new FamilySizePizzaPrice();
    }
}