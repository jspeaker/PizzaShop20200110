using PizzaShop.Franchise;
using PizzaShop.Products;
using System.Collections.Generic;

namespace PizzaShop.Controllers.Request.Strategies
{
    public interface IOrderStrategy
    {
        List<IProduct> Add(ProductRequest productRequest, LocationName locationName);
    }
}