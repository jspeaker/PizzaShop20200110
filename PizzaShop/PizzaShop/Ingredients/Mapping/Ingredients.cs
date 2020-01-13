using PizzaShop.Ingredients.Meat;
using PizzaShop.Ingredients.Standard;
using System;
using System.Collections.Generic;

namespace PizzaShop.Ingredients.Mapping
{
    public class Ingredients
    {
        public Dictionary<string, Type> Types = new Dictionary<string, Type>
        {
            { new MushroomsName(), typeof(Mushrooms) },
            { new MozzarellaName(), typeof(Mozzarella) },
            { new OlivesName(), typeof(Olives) },
            { new BaconName(), typeof(Bacon) },
            { new HamName(), typeof(Ham) },
            { new PepperoniName(), typeof(Pepperoni) }
        };
    }
}