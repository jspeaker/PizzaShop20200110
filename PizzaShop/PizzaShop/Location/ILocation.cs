using PizzaShop.PrimitiveConcepts;

namespace PizzaShop.Location
{
    public interface ILocation
    {
        Text LocalizedPrice(Money money);
    }
}