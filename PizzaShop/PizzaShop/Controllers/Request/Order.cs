using PizzaShop.Ingredients.Mapping;
using PizzaShop.Products;
using PizzaShop.Sizes;
using PizzaShop.Sizes.Mapping;
using System.Collections.Generic;
using System.Linq;

namespace PizzaShop.Controllers.Request
{
    public class Order
    {
        private readonly IngredientMap _ingredientMap;
        private readonly SizeMap _sizeMap;

        public PizzaRequest[] Pizzas { get; set; }

        public Order() : this(new IngredientMap(), new SizeMap()) { }

        private Order(IngredientMap ingredientMap, SizeMap sizeMap)
        {
            _ingredientMap = ingredientMap;
            _sizeMap = sizeMap;
        }

        public string Invoice()
        { 
            List<Pizza> pizzas = new List<Pizza>();

            foreach (PizzaRequest pizza in Pizzas)
            {
                IProductSize size = _sizeMap.DomainSize(pizza.Size);
                pizzas.Add(new Pizza(size, pizza.Ingredients.Select(i => _ingredientMap.DomainIngredient(i, new Pizza(size))).ToArray()));
            }

            return $"{string.Join("\n\n",  pizzas.Select(p => p.Description() + "\n" + p.Price()))}";
        }
    }
}