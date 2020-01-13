using PizzaShop.Ingredients.Mapping;
using PizzaShop.Products;
using PizzaShop.Products.Descriptions;
using PizzaShop.Sizes;
using PizzaShop.Sizes.Mapping;
using System.Collections.Generic;
using System.Linq;

namespace PizzaShop.Controllers.Request.Strategies
{
    public class PizzaOrderStrategy : IOrderStrategy
    {
        private readonly List<IProduct> _products;
        private readonly IngredientMap _ingredientMap;
        private readonly SizeMap _sizeMap;
        private readonly IOrderStrategy _nextStrategy;

        public PizzaOrderStrategy(List<IProduct> products) : this(products, new IngredientMap(), new SizeMap(), new CalzoneOrderStrategy(products)) { }

        public PizzaOrderStrategy(List<IProduct> products, IngredientMap ingredientMap, SizeMap sizeMap, IOrderStrategy nextStrategy)
        {
            _products = products;
            _ingredientMap = ingredientMap;
            _sizeMap = sizeMap;
            _nextStrategy = nextStrategy;
        }

        public List<IProduct> Add(ProductRequest productRequest)
        {
            if (!productRequest.Name.Equals(new PizzaProductName())) return _nextStrategy.Add(productRequest);

            IProductSize size = _sizeMap.DomainSize(productRequest.Size);
            _products.Add(new Pizza(size, productRequest.Ingredients.Select(i => _ingredientMap.DomainIngredient(i, new Pizza(size))).ToArray()));
            return _products;
        }
    }
}