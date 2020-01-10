namespace PizzaShop.PrimitiveConcepts
{
    public abstract class Text
    {
        private readonly string _value;
        protected Text(string value) => _value = value;

        public static implicit operator string(Text instance) => instance._value;

        public override string ToString() => _value;
    }
}