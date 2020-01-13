using PizzaShop.Sizes.Texts;
using System;
using System.Collections.Generic;

namespace PizzaShop.Sizes.Mapping
{
    public class Sizes
    {
        public Dictionary<string, Type> Types = new Dictionary<string, Type>
        {
            { new PersonalSizeName(), typeof(PersonalSize) },
            { new MediumSizeName(), typeof(MediumSize) },
            { new LargeSizeName(), typeof(LargeSize) }
        };
    }
}