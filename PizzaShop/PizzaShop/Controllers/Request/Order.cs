using PizzaShop.Ingredients.Mapping;
using PizzaShop.Products;
using PizzaShop.Sizes;
using PizzaShop.Sizes.Texts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaShop.Controllers.Request
{
    public class Order
    {
        private readonly IngredientMap _ingredientMap;

        public PizzaRequest[] Pizzas { get; set; }

        public Order() : this(new IngredientMap()) { }

        private Order(IngredientMap ingredientMap)
        {
            _ingredientMap = ingredientMap;
        }

        public string Invoice()
        { 
            List<Pizza> pizzas = new List<Pizza>();

            foreach (PizzaRequest pizza in Pizzas)
            {
                IProductSize size = pizza.Size.Equals(new PersonalSizeName(), StringComparison.InvariantCultureIgnoreCase) ? (IProductSize) new PersonalSize() : new FamilySize();
                pizzas.Add(new Pizza(size, pizza.Ingredients.Select(i => _ingredientMap.DomainIngredient(i, new Pizza(size))).ToArray()));
            }

            return $"{string.Join("\n\n",  pizzas.Select(p => p.Description() + " " + p.Price()))}";
        }
    }
}