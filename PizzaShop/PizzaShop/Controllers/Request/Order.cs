using PizzaShop.Controllers.Request.Strategies;
using PizzaShop.Franchise;
using PizzaShop.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaShop.Controllers.Request
{
    public class Order
    {
        private List<IProduct> _products;
        private readonly IOrderStrategy _orderStrategy;

        public string Location { get; set; }
        
        public ProductRequest[] Products { get; set; }

        public Order() : this(new List<IProduct>()) { }

        private Order(List<IProduct> products) : this(products, new PizzaOrderStrategy(products)) { }

        private Order(List<IProduct> products, IOrderStrategy orderStrategy)
        {
            _products = products;
            _orderStrategy = orderStrategy;
        }

        public string Invoice()
        {
            foreach (ProductRequest product in Products) _products = _orderStrategy.Add(product, Enum.Parse<Location>(Location));

            return $"{string.Join("\n\n", _products.Select(p => p.Description() + "\n" + p.Price()))}";
        }
    }
}