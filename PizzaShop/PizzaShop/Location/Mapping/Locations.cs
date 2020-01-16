using System;
using System.Collections.Generic;

namespace PizzaShop.Location.Mapping
{
    public class Locations
    {
        public Dictionary<LocationName, Type> Types = new Dictionary<LocationName, Type>
        {
            { LocationName.Bedrock,  typeof(BedrockLocation) },
            { LocationName.Springfield, typeof(SpringfieldLocation) },
            { LocationName.Bricksburg, typeof(BricksburgLocation) }
        };
    }
}