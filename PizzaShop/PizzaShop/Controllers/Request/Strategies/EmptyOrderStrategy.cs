using PizzaShop.Products;
using System.Collections.Generic;

namespace PizzaShop.Controllers.Request.Strategies
{
    public class EmptyOrderStrategy : IOrderStrategy
    {
        private readonly List<IProduct> _products;

        public EmptyOrderStrategy(List<IProduct> products) => _products = products;

        public List<IProduct> Add(ProductRequest productRequest) => _products;
    }
}