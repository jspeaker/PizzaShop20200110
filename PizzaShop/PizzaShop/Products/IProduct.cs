using PizzaShop.PrimitiveConcepts;

namespace PizzaShop.Products
{
    public interface IProduct
    {
        string Description();
        Money Price();
        // extend to provide Price that takes a
        // Location OBJECT not the enum, the object containing the name and currency object -
    }
}