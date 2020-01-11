using PizzaShop.PrimitiveConcepts;

namespace PizzaShop.Sizes
{
    public abstract class ProductSize : IProductSize
    {
        private readonly Text _sizeName;
        private readonly Money _price;

        protected ProductSize(Text sizeName, Money price)
        {
            _sizeName = sizeName;
            _price = price;
        }

        public static implicit operator string(ProductSize instance) => instance._sizeName;

        public override string ToString() => _sizeName;

        public virtual Money Price() => _price;

        public override bool Equals(object other) => other != null && other.ToString().Equals(_sizeName);

        public override int GetHashCode() => _sizeName.GetHashCode() * 17 + Price().GetHashCode();
    }
}