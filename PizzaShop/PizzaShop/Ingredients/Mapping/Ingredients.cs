using PizzaShop.Ingredients.Meat;
using PizzaShop.Ingredients.Meat.Texts;
using PizzaShop.Ingredients.Premium;
using PizzaShop.Ingredients.Premium.Texts;
using PizzaShop.Ingredients.Standard;
using PizzaShop.Ingredients.Standard.Texts;
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
            { new CrispyHamName(), typeof(CrispyHam) },
            { new HamName(), typeof(Ham) },
            { new PepperoniName(), typeof(Pepperoni) },
            { new RoastedGarlicName(), typeof(RoastedGarlic) },
            { new SundriedTomatoesName(), typeof(SundriedTomatoes) },
            { new FetaCheeseName(), typeof(FetaCheese) },
            { new ThymeAndRosemaryName(), typeof(ThymeAndRosemary) },
            { new AsiagoCheeseName(), typeof(AsiagoCheese) }
        };
    }
}