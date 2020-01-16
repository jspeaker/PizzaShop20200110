using System;

namespace PizzaShop.Location.Mapping
{
    public class LocationMap
    {
        private readonly LocationName _locationName;

        public LocationMap(LocationName locationName) => _locationName = locationName;

        public ILocation DomainLocation() => (ILocation)Activator.CreateInstance(new Locations().Types[_locationName]);
    }
}