using PizzaShop.Franchise;
using PizzaShop.Ingredients.Mapping;
using PizzaShop.Products;
using PizzaShop.Products.Descriptions;
using PizzaShop.Sizes;
using PizzaShop.Sizes.Mapping;
using System.Collections.Generic;
using System.Linq;

namespace PizzaShop.Controllers.Request.Strategies
{
    public class CalzoneOrderStrategy : IOrderStrategy
    {
        private readonly List<IProduct> _products;
        private readonly IngredientMap _ingredientMap;
        private readonly SizeMap _sizeMap;
        private readonly IOrderStrategy _nextStrategy;

        public CalzoneOrderStrategy(List<IProduct> products) : this(products, new IngredientMap() , new SizeMap(), new EmptyOrderStrategy(products)) { }

        public CalzoneOrderStrategy(List<IProduct> products, IngredientMap ingredientMap, SizeMap sizeMap, IOrderStrategy nextStrategy)
        {
            _products = products;
            _ingredientMap = ingredientMap;
            _sizeMap = sizeMap;
            _nextStrategy = nextStrategy;
        }

        public List<IProduct> Add(ProductRequest productRequest, Location location)
        {
            if (!productRequest.Name.Equals(new CalzoneProductName())) return _nextStrategy.Add(productRequest, location);

            IProductSize size = _sizeMap.DomainSize(productRequest.Size);
            _products.Add(new Calzone(size, productRequest.Ingredients.Select(i => _ingredientMap.DomainIngredient(i, new Calzone(size), location)).ToArray()));
            return _products;
        }
    }
}