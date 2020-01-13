using PizzaShop.Prices;
using PizzaShop.Sizes.Texts;

namespace PizzaShop.Sizes
{
    public class FullCalzoneSize : ProductSize
    {
        public FullCalzoneSize() : base(new FullSizeName(), new FullSizeCalzonePrice()) { }
    }
}