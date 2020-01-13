using System;

namespace PizzaShop.Sizes.Mapping
{
    public class SizeMap
    {
        private readonly Sizes _sizes;

        public SizeMap() : this(new Sizes()) { }

        private SizeMap(Sizes sizes) => _sizes = sizes;

        public IProductSize DomainSize(string name)
        {
            return (IProductSize) Activator.CreateInstance(_sizes.Types[name]);
        }
    }
}