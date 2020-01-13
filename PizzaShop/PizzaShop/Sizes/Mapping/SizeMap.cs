using System;

namespace PizzaShop.Sizes.Mapping
{
    public class SizeMap
    {
        private readonly PizzaShop.Sizes.Mapping.Sizes _sizes;

        public SizeMap() : this(new PizzaShop.Sizes.Mapping.Sizes()) { }

        private SizeMap(PizzaShop.Sizes.Mapping.Sizes sizes)
        {
            _sizes = sizes;
        }

        public IProductSize DomainSize(string name)
        {
            return (IProductSize) Activator.CreateInstance(_sizes.Types[name]);
        }
    }
}