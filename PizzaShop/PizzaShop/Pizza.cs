using PizzaShop.Descriptions;
using PizzaShop.Sizes;

namespace PizzaShop
{
    public interface IProduct
    {
        string Description();
        decimal Price();
        bool IsSize(IProductSize size);
    }

    public class Pizza : IProduct
    {
        public Pizza() : this(new PersonalSize()) { }

        public Pizza(IProductSize size) => _size = size;

        private readonly string _productName = new PizzaProductName(); 

        private readonly IProductSize _size;

        public string Description() => $"{_size} {_productName}";

        public bool IsSize(IProductSize size) => _size.Equals(size);

        public decimal Price() => _size.Price();
    }
}