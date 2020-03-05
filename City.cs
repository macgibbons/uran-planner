using System;
using System.Collections.Generic;
namespace Planner
{

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

        public string Descrition
        {
            get
            {
                return $@"
                {CityName}
                ------------
                Mayor:  {Mayor}
                Founded: {YearFounded}";
            }
        }
        public List<Building> CityBuildings { get; set; } = new List<Building> ();

        public void addBuildingToCity (Building building)
        {
            CityBuildings.Add (building);
        }

    }

}