using PizzaShop.Controllers.Request.Strategies;
using PizzaShop.Location;
using PizzaShop.Location.Mapping;
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

        public Invoice Invoice()
        {
            ILocation domainLocation = new LocationMap(Enum.Parse<LocationName>(Location)).DomainLocation();

            foreach (ProductRequest product in Products)
            {
                _products = _orderStrategy.Add(product, domainLocation);
            }

            return new Invoice(_products.Select(p => new LineItem(p.Description(), domainLocation.LocalizedPrice(p.Price()))).ToList());
        }
    }
}