namespace PizzaShop.PrimitiveConcepts
{
    public class Money
    {
        private readonly decimal _value;
        protected Money(decimal value) => _value = value;

        public static implicit operator decimal(Money instance) => instance._value;
    }
}