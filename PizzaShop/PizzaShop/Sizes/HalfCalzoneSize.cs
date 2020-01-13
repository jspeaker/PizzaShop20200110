using PizzaShop.Prices;
using PizzaShop.Sizes.Texts;

namespace PizzaShop.Sizes
{
    public class HalfCalzoneSize : ProductSize
    {
        public HalfCalzoneSize() : base(new HalfSizeName(), new HalfSizeCalzonePrice()) { }
    }
}