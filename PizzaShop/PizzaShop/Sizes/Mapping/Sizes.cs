using PizzaShop.Sizes.Texts;
using System;
using System.Collections.Generic;

namespace PizzaShop.Sizes.Mapping
{
    public class Sizes
    {
        public Dictionary<string, Type> Types = new Dictionary<string, Type>
        {
            { new PersonalSizeName(), typeof(PersonalPizzaSize) },
            { new MiniSizeName(), typeof(MiniPizzaSize) },
            { new MediumSizeName(), typeof(MediumPizzaSize) },
            { new LargeSizeName(), typeof(LargePizzaSize) },
            { new FullSizeName(), typeof(FullCalzoneSize) },
            { new HalfSizeName(), typeof(HalfCalzoneSize) }
        };
    }
}