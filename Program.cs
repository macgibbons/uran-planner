using System;

namespace Planner
{
    class Program
    {
        static void Main (string[] args)
        {
            Building FiveOneTwoEigth = new Building ("512 8th Avenue")
            {
                Width = 3000,
                Depth = 10000,
                Stories = 10,

            };
            Building ThreeZeroOne = new Building ("301 Plus Park Blvd")
            {
                Width = 351,
                Depth = 1587,
                Stories = 10,
            };

            FiveOneTwoEigth.Construct ();
            FiveOneTwoEigth.Purchase ("Kev the Dev");

            ThreeZeroOne.Construct ();
            ThreeZeroOne.Purchase ("John Wark");

            City Macville = new City ("Macville", "Mac Gibbons", 1992);
            Macville.addBuildingToCity (ThreeZeroOne);

            Console.WriteLine (FiveOneTwoEigth.Descrition);
            Console.WriteLine (ThreeZeroOne.Descrition);
            Console.WriteLine (Macville.Descrition);

            foreach (Building building in Macville.CityBuildings)
            {
                Console.WriteLine (building.Descrition);
            }

        }
    }
}