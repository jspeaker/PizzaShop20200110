using PizzaShop.PrimitiveConcepts;

namespace PizzaShop.Sizes
{
    public abstract class ProductSize : IProductSize
    {
        protected readonly Text SizeName;

        protected ProductSize(Text sizeName) => SizeName = sizeName;

        public virtual Money Price() => new Free();

        public override string ToString() => SizeName;

        public override bool Equals(object other) => other != null && other.ToString().Equals(SizeName);

        public override int GetHashCode() => SizeName.GetHashCode() * 17 + Price().GetHashCode();
    }

    public class Free : Money
    {
        public Free() : base(0) { }
    }
}