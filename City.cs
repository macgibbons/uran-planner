using System;
using System.Collections.Generic;
namespace Planner
{

    //     Name of the city.
    // The mayor of the city.
    // Year the city was established.
    // A collection of all of the buildings in the city.
    // A method to add a building to the city.
    // Remember, each class should be in its own file. Create a City.cs file and define the City class in there. Make sure it's in the same namespace as your other classes.

    // Once the class is defined to your liking, refactor your code in Main() 
    // to create a new city instance and add your buildings to it. Once all buildings are in the city, refactor your code that outputs the building info to the console to be inside a foreach loop that iterate the city's building collection.
    public class City
    {
        public string CityName { get; set; }
        public int YearFounded { get; set; }
        public string Mayor { get; set; }
        public City (string cityName, string mayor, int year)
        {
            CityName = cityName;
            Mayor = mayor;
            YearFounded = year;
        }

        public List<Building> CityBuildings { get; set; } = new List<Building> ();

        public void addBuildingToCity (Building building)
        {
            CityBuildings.Add (building);
        }

    }

}