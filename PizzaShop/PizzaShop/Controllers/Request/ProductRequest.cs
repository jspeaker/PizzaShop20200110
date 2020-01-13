namespace PizzaShop.Controllers.Request
{
    public class ProductRequest
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string[] Ingredients { get; set; }
    }
}