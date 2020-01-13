using System.Collections.Generic;
using PizzaShop.Products;

namespace PizzaShop.Controllers.Request.Strategies
{
    public interface IOrderStrategy
    {
        List<IProduct> Add(ProductRequest productRequest);
    }
}